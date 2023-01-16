using System;
using System.Net;
using System.Threading.Tasks;

using Eighty.AspNetCore.Mvc.ResultExecutors;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Eighty.AspNetCore.Mvc.ActionResults;

/// <summary>
/// An <see cref="IActionResult"/> which renders an <see cref="IHtmlRenderer{TModel}"/> using a <typeparamref name="TModel"/>.
/// </summary>
/// <typeparam name="TModel">The model type.</typeparam>
public class HtmlRendererResult<TModel> : IActionResult
{
    /// <summary>
    /// The view.
    /// </summary>
    public IHtmlRenderer<TModel> View { get; }

    /// <summary>
    /// The mode.
    /// </summary>
    public TModel Model { get; }

    /// <summary>
    /// A custom status code.
    /// </summary>
    public HttpStatusCode? StatusCode { get; }

    /// <summary>
    /// Render the HTML into the response asynchronously.
    /// </summary>
    public bool RenderAsync { get; }

    /// <summary>
    /// Creates an <see cref="HtmlRendererResult{TModel}"/>.
    /// </summary>
    /// <param name="view">The view.</param>
    /// <param name="model">The model.</param>
    /// <param name="statusCode">A custom status code.</param>
    /// <param name="renderAsync">Render the HTML into the response asynchronously.</param>
    public HtmlRendererResult(IHtmlRenderer<TModel> view, TModel model, HttpStatusCode? statusCode = null, bool renderAsync = false)
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

        var executor = context.HttpContext.RequestServices.GetRequiredService<HtmlRendererResultExecutor<TModel>>();
        await executor.ExecuteAsync(context, this).ConfigureAwait(false);
    }
}
