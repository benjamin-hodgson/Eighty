using System;
using System.Text;
using System.Threading.Tasks;
using Eighty.AspNetCore.Mvc.ActionResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.Extensions.Logging;

namespace Eighty.AspNetCore.Mvc.ResultExecutors
{
    /// <summary>
    /// Executes a <see cref="HtmlBuilderResult"/>
    /// </summary>
    public class HtmlBuilderResultExecutor
    {
        private const string DefaultContentType = "text/plain; charset=utf-8";
        private readonly ILogger _logger;
        private readonly IHttpResponseStreamWriterFactory _writerFactory;

        /// <summary>
        /// Creates an <see cref="HtmlBuilderResultExecutor"/>
        /// </summary>
        /// <param name="logger">The logger</param>
        /// <param name="writerFactory">The writer factory</param>
        public HtmlBuilderResultExecutor(
            ILogger<HtmlBuilderResultExecutor> logger,
            IHttpResponseStreamWriterFactory writerFactory
        )
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }
            if (writerFactory == null)
            {
                throw new ArgumentNullException(nameof(writerFactory));
            }
            _logger = logger;
            _writerFactory = writerFactory;
        }

        /// <summary>
        /// Execute the <see cref="HtmlBuilderResult"/>
        /// </summary>
        /// <param name="context">The action context</param>
        /// <param name="result">The action result</param>
        public async Task Execute(ActionContext context, HtmlBuilderResult result)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

            _logger.LogInformation(1, "Executing HtmlBuilderResult");

            var response = context.HttpContext.Response;

            if (result.StatusCode != null)
            {
                response.StatusCode = (int)result.StatusCode.Value;
            }
            response.ContentType = "text/html; charset=utf-8";

            using (var writer = _writerFactory.CreateWriter(response.Body, Encoding.UTF8))
            {
                result.HtmlBuilder.Write(writer);
                await writer.FlushAsync();
            }
        }
    }
}
