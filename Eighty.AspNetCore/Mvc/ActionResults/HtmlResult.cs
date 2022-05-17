using System;
using System.Net;
using System.Threading.Tasks;

using Eighty.AspNetCore.Mvc.ResultExecutors;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Eighty.AspNetCore.Mvc.ActionResults;

/// <summary>
/// An <see cref="IActionResult"/> which renders some <see cref="Html"/>
/// </summary>
public class HtmlResult : IActionResult
{
    /// <summary>
    /// The <see cref="Html"/>
    /// </summary>
    /// <returns>The <see cref="Html"/></returns>
    public Html Html { get; }
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
    /// Creates an <see cref="HtmlResult"/>
    /// </summary>
    /// <param name="html">The <see cref="Html"/></param>
    /// <param name="statusCode">A custom status code</param>
    /// <param name="renderAsync">Render the HTML into the response asynchronously</param>
    public HtmlResult(Html html, HttpStatusCode? statusCode = null, bool renderAsync = false)
    {
        if (html == null)
        {
            throw new ArgumentNullException(nameof(html));
        }
        Html = html;
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

        var executor = context.HttpContext.RequestServices.GetRequiredService<HtmlResultExecutor>();
        await executor.ExecuteAsync(context, this);
    }
}
