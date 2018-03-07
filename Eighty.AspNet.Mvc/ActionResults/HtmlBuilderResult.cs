using System;
using System.Net;
using System.Web.Mvc;
using Eighty.Twenty;

namespace Eighty.AspNet.Mvc.ActionResults
{
    /// <summary>
    /// An <see cref="IActionResult"/> which renders an <see cref="HtmlBuilder"/>
    /// </summary>
    public class HtmlBuilderResult : ActionResult
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
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var response = context.HttpContext.Response;

            if (StatusCode != null)
            {
                response.StatusCode = (int)StatusCode.Value;
            }
            response.ContentType = "text/html; charset=utf-8";

            HtmlBuilder.Write(response.Output);
        }
    }
}