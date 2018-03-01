using System;
using System.Net;
using System.Threading.Tasks;
using Eighty.AspNetCore.Mvc.ResultExecutors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Eighty.AspNetCore.Mvc.ActionResults
{
    /// <summary>
    /// An <see cref="IActionResult"/> which renders an <see cref="ITwentyView{TModel}"/> using a <typeparamref name="TModel"/>
    /// </summary>
    /// <typeparam name="TModel">The model type</typeparam>
    public class TwentyViewResult<TModel> : IActionResult
    {
        /// <summary>
        /// The view
        /// </summary>
        /// <returns>The view</returns>
        public ITwentyView<TModel> View { get; }
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
        /// Creates a <see cref="TwentyViewResult{TModel}"/>
        /// </summary>
        /// <param name="view">The view</param>
        /// <param name="model">The model</param>
        /// <param name="statusCode">A custom status code</param>
        public TwentyViewResult(ITwentyView<TModel> view, TModel model, HttpStatusCode? statusCode = null)
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
        public async Task ExecuteResultAsync(ActionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var executor = context.HttpContext.RequestServices.GetRequiredService<TwentyViewResultExecutor<TModel>>();
            await executor.ExecuteAsync(context, this);
        }
    }
}