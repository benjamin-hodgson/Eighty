using System;
using System.Net;
using System.Threading.Tasks;

using Eighty.AspNetCore.Mvc.ResultExecutors;
using Eighty.Twenty;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Eighty.AspNetCore.Mvc.ActionResults;

/// <summary>
/// An <see cref="IActionResult"/> which renders an <see cref="IHtmlBuilderRenderer{TModel}"/> using a <typeparamref name="TModel"/>.
/// </summary>
/// <typeparam name="TModel">The model type.</typeparam>
public class HtmlBuilderRendererResult<TModel> : IActionResult
{
    /// <summary>
    /// The view.
    /// </summary>
    public IHtmlBuilderRenderer<TModel> View { get; }

    /// <summary>
    /// The model.
    /// </summary>
    public TModel Model { get; }

    /// <summary>
    /// A custom status code.
    /// </summary>
    public HttpStatusCode? StatusCode { get; }

    /// <summary>
    /// Creates a <see cref="HtmlBuilderRendererResult{TModel}"/>.
    /// </summary>
    /// <param name="view">The view.</param>
    /// <param name="model">The model.</param>
    /// <param name="statusCode">A custom status code.</param>
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
    public async Task ExecuteResultAsync(ActionContext context)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }

        var executor = context.HttpContext.RequestServices.GetRequiredService<HtmlBuilderRendererResultExecutor<TModel>>();
        await executor.ExecuteAsync(context, this).ConfigureAwait(false);
    }
}
