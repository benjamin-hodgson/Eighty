using System;
using System.Net;
using System.Threading.Tasks;
using Eighty.AspNetCore.Mvc.ResultExecutors;
using Eighty.Twenty;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Eighty.AspNetCore.Mvc.ActionResults
{
    public class HtmlBuilderResult : IActionResult
    {
        public HtmlBuilder HtmlBuilder { get; }
        public HttpStatusCode? StatusCode { get; }

        public HtmlBuilderResult(HtmlBuilder htmlBuilder, HttpStatusCode? statusCode = null)
        {
            if (htmlBuilder == null)
            {
                throw new ArgumentNullException(nameof(htmlBuilder));
            }
            HtmlBuilder = htmlBuilder;
            StatusCode = statusCode;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var executor = context.HttpContext.RequestServices.GetRequiredService<HtmlBuilderResultExecutor>();
            await executor.Execute(context, this);
        }
    }
}