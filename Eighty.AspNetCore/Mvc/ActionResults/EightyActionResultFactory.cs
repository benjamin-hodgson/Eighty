using System;
using System.Net;
using Eighty.Twenty;
using Microsoft.AspNetCore.Mvc;

namespace Eighty.AspNetCore.Mvc.ActionResults
{
    public static class EightyActionResultFactory
    {
        public static EightyViewResult<TModel> ToActionResult<TModel>(
            this IEightyView<TModel> view,
            TModel model,
            HttpStatusCode? statusCode = null,
            bool renderAsync = false
        ) => Create(view, model, statusCode, renderAsync);

        public static EightyViewResult<TModel> Create<TModel>(
            IEightyView<TModel> view,
            TModel model,
            HttpStatusCode? statusCode = null,
            bool renderAsync = false
        )
        {
            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }
            return new EightyViewResult<TModel>(view, model, statusCode, renderAsync);
        }
        public static TwentyViewResult<TModel> ToActionResult<TModel>(
            this ITwentyView<TModel> view,
            TModel model,
            HttpStatusCode? statusCode = null
        ) => Create(view, model, statusCode);

        public static TwentyViewResult<TModel> Create<TModel>(
            ITwentyView<TModel> view,
            TModel model,
            HttpStatusCode? statusCode = null
        )
        {
            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }
            return new TwentyViewResult<TModel>(view, model, statusCode);
        }

        public static HtmlResult ToActionResult(
            this Html html,
            HttpStatusCode? statusCode = null,
            bool renderAsync = false
        ) => Create(html, statusCode, renderAsync);

        public static HtmlResult Create(
            Html html,
            HttpStatusCode? statusCode = null,
            bool renderAsync = false
        )
        {
            if (html == null)
            {
                throw new ArgumentNullException(nameof(html));
            }
            return new HtmlResult(html, statusCode, renderAsync);
        }

        public static HtmlBuilderResult ToActionResult(
            this HtmlBuilder htmlBuilder,
            HttpStatusCode? statusCode = null
        ) => Create(htmlBuilder, statusCode);

        public static HtmlBuilderResult Create(
            HtmlBuilder htmlBuilder,
            HttpStatusCode? statusCode = null
        )
        {
            if (htmlBuilder == null)
            {
                throw new ArgumentNullException(nameof(htmlBuilder));
            }
            return new HtmlBuilderResult(htmlBuilder, statusCode);
        }
    }
}