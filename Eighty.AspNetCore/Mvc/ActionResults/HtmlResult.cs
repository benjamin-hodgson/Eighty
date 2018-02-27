using System;
using System.Net;
using System.Threading.Tasks;
using Eighty.AspNetCore.Mvc.ResultExecutors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Eighty.AspNetCore.Mvc.ActionResults
{
    public class HtmlResult : IActionResult
    {
        public Html Html { get; }
        public HttpStatusCode? StatusCode { get; }
        public bool RenderAsync { get; }

        public HtmlResult(Html html, HttpStatusCode? statusCode = null, bool renderAsync = false)
        {
            if (html == null)
            {
                throw new ArgumentNullException(nameof(html));
            }
            Html = html;
            StatusCode = statusCode;
            RenderAsync = renderAsync;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var executor = context.HttpContext.RequestServices.GetRequiredService<HtmlResultExecutor>();
            await executor.ExecuteAsync(context, this);
        }
    }
}