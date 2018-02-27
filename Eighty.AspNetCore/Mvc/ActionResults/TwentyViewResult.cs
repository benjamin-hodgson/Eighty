using System;
using System.Net;
using System.Threading.Tasks;
using Eighty.AspNetCore.Mvc.ResultExecutors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Eighty.AspNetCore.Mvc.ActionResults
{
    public class TwentyViewResult<TModel> : IActionResult
    {
        public ITwentyView<TModel> View { get; }
        public TModel Model { get; }
        public HttpStatusCode? StatusCode { get; }

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