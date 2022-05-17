using System;
using System.Net;

using Eighty.Twenty;

using Microsoft.AspNetCore.Mvc;

namespace Eighty.AspNetCore.Mvc.ActionResults;

/// <summary>
/// Methods for creating <see cref="IActionResult"/>s
/// </summary>
public static class EightyActionResultFactory
{
    /// <summary>
    /// Creates an <see cref="IActionResult"/> from an <see cref="IHtmlRenderer{TModel}"/> and a <typeparamref name="TModel"/>
    /// </summary>
    /// <typeparam name="TModel">The model type</typeparam>
    /// <param name="view">The view</param>
    /// <param name="model">The model</param>
    /// <param name="statusCode">A custom status code</param>
    /// <param name="renderAsync">Write the HTML to the response asynchronously</param>
    /// <returns>An <see cref="IActionResult"/></returns>
    public static HtmlRendererResult<TModel> ToActionResult<TModel>(
        this IHtmlRenderer<TModel> view,
        TModel model,
        HttpStatusCode? statusCode = null,
        bool renderAsync = false
    ) => Create(view, model, statusCode, renderAsync);

    /// <summary>
    /// Creates an <see cref="IActionResult"/> from an <see cref="IHtmlRenderer{TModel}"/> and a <typeparamref name="TModel"/>
    /// </summary>
    /// <typeparam name="TModel">The model type</typeparam>
    /// <param name="view">The view</param>
    /// <param name="model">The model</param>
    /// <param name="statusCode">A custom status code</param>
    /// <param name="renderAsync">Write the HTML to the response asynchronously</param>
    /// <returns>An <see cref="IActionResult"/></returns>
    public static HtmlRendererResult<TModel> Create<TModel>(
        IHtmlRenderer<TModel> view,
        TModel model,
        HttpStatusCode? statusCode = null,
        bool renderAsync = false
    )
    {
        if (view == null)
        {
            throw new ArgumentNullException(nameof(view));
        }
        return new HtmlRendererResult<TModel>(view, model, statusCode, renderAsync);
    }


    /// <summary>
    /// Creates an <see cref="IActionResult"/> from an <see cref="IHtmlBuilderRenderer{TModel}"/> and a <typeparamref name="TModel"/>
    /// </summary>
    /// <typeparam name="TModel">The model type</typeparam>
    /// <param name="view">The view</param>
    /// <param name="model">The model</param>
    /// <param name="statusCode">A custom status code</param>
    /// <returns>An <see cref="IActionResult"/></returns>
    public static HtmlBuilderRendererResult<TModel> ToActionResult<TModel>(
        this IHtmlBuilderRenderer<TModel> view,
        TModel model,
        HttpStatusCode? statusCode = null
    ) => Create(view, model, statusCode);

    /// <summary>
    /// Creates an <see cref="IActionResult"/> from an <see cref="IHtmlBuilderRenderer{TModel}"/> and a <typeparamref name="TModel"/>
    /// </summary>
    /// <typeparam name="TModel">The model type</typeparam>
    /// <param name="view">The view</param>
    /// <param name="model">The model</param>
    /// <param name="statusCode">A custom status code</param>
    /// <returns>An <see cref="IActionResult"/></returns>
    public static HtmlBuilderRendererResult<TModel> Create<TModel>(
        IHtmlBuilderRenderer<TModel> view,
        TModel model,
        HttpStatusCode? statusCode = null
    )
    {
        if (view == null)
        {
            throw new ArgumentNullException(nameof(view));
        }
        return new HtmlBuilderRendererResult<TModel>(view, model, statusCode);
    }

    /// <summary>
    /// Creates an <see cref="IActionResult"/> from some <see cref="Html"/>
    /// </summary>
    /// <param name="html">The HTML</param>
    /// <param name="statusCode">A custom status code</param>
    /// <param name="renderAsync">Write the HTML to the response asynchronously</param>
    /// <returns>An <see cref="IActionResult"/></returns>
    public static HtmlResult ToActionResult(
        this Html html,
        HttpStatusCode? statusCode = null,
        bool renderAsync = false
    ) => Create(html, statusCode, renderAsync);

    /// <summary>
    /// Creates an <see cref="IActionResult"/> from some <see cref="Html"/>
    /// </summary>
    /// <param name="html">The HTML</param>
    /// <param name="statusCode">A custom status code</param>
    /// <param name="renderAsync">Write the HTML to the response asynchronously</param>
    /// <returns>An <see cref="IActionResult"/></returns>
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

    /// <summary>
    /// Creates an <see cref="IActionResult"/> from an <see cref="HtmlBuilder"/>
    /// </summary>
    /// <param name="htmlBuilder">The HTML builder</param>
    /// <param name="statusCode">A custom status code</param>
    /// <returns>An <see cref="IActionResult"/></returns>
    public static HtmlBuilderResult ToActionResult(
        this HtmlBuilder htmlBuilder,
        HttpStatusCode? statusCode = null
    ) => Create(htmlBuilder, statusCode);

    /// <summary>
    /// Creates an <see cref="IActionResult"/> from an <see cref="HtmlBuilder"/>
    /// </summary>
    /// <param name="htmlBuilder">The HTML builder</param>
    /// <param name="statusCode">A custom status code</param>
    /// <returns>An <see cref="IActionResult"/></returns>
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
