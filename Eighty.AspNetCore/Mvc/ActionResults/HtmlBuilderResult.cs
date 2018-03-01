using System;
using System.Net;
using System.Threading.Tasks;
using Eighty.AspNetCore.Mvc.ResultExecutors;
using Eighty.Twenty;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Eighty.AspNetCore.Mvc.ActionResults
{
    /// <summary>
    /// An <see cref="IActionResult"/> which renders an <see cref="HtmlBuilder"/>
    /// </summary>
    public class HtmlBuilderResult : IActionResult
    {
        /// <summary>
        /// The <see cref="HtmlBuilder"/>
        /// </summary>
        /// <returns>The <see cref="HtmlBuilder"/></returns>
        public HtmlBuilder HtmlBuilder { get; }
        /// <summary>
        /// A custom status code
        /// </summary>
        /// <returns>A custom status code</returns>
        public HttpStatusCode? StatusCode { get; }

        /// <summary>
        /// Creates an <see cref="HtmlBuilderResult"/>
        /// </summary>
        /// <param name="htmlBuilder">The <see cref="HtmlBuilder"/></param>
        /// <param name="statusCode">A custom status code</param>
        public HtmlBuilderResult(HtmlBuilder htmlBuilder, HttpStatusCode? statusCode = null)
        {
            if (htmlBuilder == null)
            {
                throw new ArgumentNullException(nameof(htmlBuilder));
            }
            HtmlBuilder = htmlBuilder;
            StatusCode = statusCode;
        }

        /// <inheritdoc/>
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