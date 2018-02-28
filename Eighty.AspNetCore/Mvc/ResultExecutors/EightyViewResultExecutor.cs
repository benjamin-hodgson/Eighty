using System;
using System.Text;
using System.Threading.Tasks;
using Eighty.AspNetCore.Mvc.ActionResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.Extensions.Logging;

namespace Eighty.AspNetCore.Mvc.ResultExecutors
{
    public class EightyViewResultExecutor<TModel>
    {
        private const string DefaultContentType = "text/plain; charset=utf-8";
        private readonly ILogger _logger;
        private readonly IHttpResponseStreamWriterFactory _writerFactory;

        public EightyViewResultExecutor(
            ILoggerFactory loggerFactory,
            IHttpResponseStreamWriterFactory writerFactory
        )
        {
            if (loggerFactory == null)
            {
                throw new ArgumentNullException(nameof(loggerFactory));
            }
            if (writerFactory == null)
            {
                throw new ArgumentNullException(nameof(writerFactory));
            }
            _logger = loggerFactory.CreateLogger(typeof(EightyViewResultExecutor<>));
            _writerFactory = writerFactory;
        }

        public async Task ExecuteAsync(ActionContext context, EightyViewResult<TModel> result)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

            _logger.LogInformation(1, "Executing EightyViewResult<{0}>", typeof(TModel).Name);

            var response = context.HttpContext.Response;

            if (result.StatusCode != null)
            {
                response.StatusCode = (int)result.StatusCode.Value;
            }
            response.ContentType = "text/html; charset=utf-8";

            var html = result.View.Render(result.Model);
            using (var writer = _writerFactory.CreateWriter(response.Body, Encoding.UTF8))
            {
                if (result.RenderAsync)
                {
                    await html.WriteAsync(writer);
                    await writer.FlushAsync();
                }
                else
                {
                    html.Write(writer);
                    await writer.FlushAsync();
                }
            }
        }
    }
}