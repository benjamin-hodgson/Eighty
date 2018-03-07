using System;
using System.Net;
using System.Web.Mvc;
using Eighty.Twenty;

namespace Eighty.AspNet.Mvc.ActionResults
{
    /// <summary>
    /// An <see cref="ActionResult"/> which renders an <see cref="IHtmlBuilderRenderer{TModel}"/> using a <typeparamref name="TModel"/>
    /// </summary>
    /// <typeparam name="TModel">The model type</typeparam>
    public class HtmlBuilderRendererResult<TModel> : ActionResult
    {
        /// <summary>
        /// The view
        /// </summary>
        /// <returns>The view</returns>
        public IHtmlBuilderRenderer<TModel> View { get; }
        /// <summary>
        /// The model
        /// </summary>
        /// <returns>The model</returns>
        public TModel Model { get; }
        /// <summary>
        /// A custom status code
        /// </summary>
        /// <returns>A custom status code</returns>
        public HttpStatusCode? StatusCode { get; }

        /// <summary>
        /// Creates a <see cref="HtmlBuilderRendererResult{TModel}"/>
        /// </summary>
        /// <param name="view">The view</param>
        /// <param name="model">The model</param>
        /// <param name="statusCode">A custom status code</param>
        public HtmlBuilderRendererResult(IHtmlBuilderRenderer<TModel> view, TModel model, HttpStatusCode? statusCode = null)
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

            var htmlBuilder = View.GetHtmlBuilder(Model);
            htmlBuilder.Write(response.Output);
        }
    }
}