using System;
using System.Net;
using System.Threading.Tasks;
using Eighty.AspNetCore.Mvc.ResultExecutors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Eighty.AspNetCore.Mvc.ActionResults
{
    /// <summary>
    /// An <see cref="IActionResult"/> which renders an <see cref="IEightyView{TModel}"/> using a <typeparamref name="TModel"/>
    /// </summary>
    /// <typeparam name="TModel">The model type</typeparam>
    public class EightyViewResult<TModel> : IActionResult
    {
        /// <summary>
        /// The view
        /// </summary>
        /// <returns>The view</returns>
        public IEightyView<TModel> View { get; }
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
        /// Render the HTML into the response asynchronously
        /// </summary>
        /// <returns>Render the HTML into the response asynchronously</returns>
        public bool RenderAsync { get; }

        /// <summary>
        /// Creates an <see cref="EightyViewResult{TModel}"/>
        /// </summary>
        /// <param name="view">The view</param>
        /// <param name="model">The model</param>
        /// <param name="statusCode">A custom status code</param>
        /// <param name="renderAsync">Render the HTML into the response asynchronously</param>
        public EightyViewResult(IEightyView<TModel> view, TModel model, HttpStatusCode? statusCode = null, bool renderAsync = false)
        {
            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }
            View = view;
            Model = model;
            StatusCode = statusCode;
            RenderAsync = renderAsync;
        }

        /// <inheritdoc/>
        public async Task ExecuteResultAsync(ActionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var executor = context.HttpContext.RequestServices.GetRequiredService<EightyViewResultExecutor<TModel>>();
            await executor.ExecuteAsync(context, this);
        }
    }
}