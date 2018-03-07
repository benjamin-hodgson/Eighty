using System;
using System.Net;
using System.Web.Mvc;

namespace Eighty.AspNet.Mvc.ActionResults
{
    /// <summary>
    /// An <see cref="IActionResult"/> which renders an <see cref="IHtmlRenderer{TModel}"/> using a <typeparamref name="TModel"/>
    /// </summary>
    /// <typeparam name="TModel">The model type</typeparam>
    public class HtmlRendererResult<TModel> : ActionResult
    {
        /// <summary>
        /// The view
        /// </summary>
        /// <returns>The view</returns>
        public IHtmlRenderer<TModel> View { get; }
        /// <summary>
        /// The mode
        /// </summary>
        /// <returns>The mode</returns>
        public TModel Model { get; }
        /// <summary>
        /// A custom status code
        /// </summary>
        /// <returns>A custom status code</returns>
        public HttpStatusCode? StatusCode { get; }

        /// <summary>
        /// Creates an <see cref="HtmlRendererResult{TModel}"/>
        /// </summary>
        /// <param name="view">The view</param>
        /// <param name="model">The model</param>
        /// <param name="statusCode">A custom status code</param>
        /// <param name="renderAsync">Render the HTML into the response asynchronously</param>
        public HtmlRendererResult(IHtmlRenderer<TModel> view, TModel model, HttpStatusCode? statusCode = null)
        {
            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }
            View = view;
            Model = model;
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

            var html = View.Render(Model);
            html.Write(response.Output);
        }
    }
}