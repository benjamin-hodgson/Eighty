using System;
using System.Net;
using System.Threading.Tasks;
using Eighty.AspNetCore.Mvc.ResultExecutors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Eighty.AspNetCore.Mvc.ActionResults
{
    public class EightyViewResult<TModel> : IActionResult
    {
        public IEightyView<TModel> View { get; }
        public TModel Model { get; }
        public HttpStatusCode? StatusCode { get; }
        public bool RenderAsync { get; }

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