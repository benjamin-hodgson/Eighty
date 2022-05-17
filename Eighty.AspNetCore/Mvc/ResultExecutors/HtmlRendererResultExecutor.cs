using System;
using System.Text;
using System.Threading.Tasks;

using Eighty.AspNetCore.Mvc.ActionResults;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;

namespace Eighty.AspNetCore.Mvc.ResultExecutors;

/// <summary>
/// Executes a <see cref="HtmlRendererResult{TModel}"/>
/// </summary>
public class HtmlRendererResultExecutor<TModel>
{
    private static readonly Action<ILogger, string, Exception> _loggerMsg = LoggerMessage.Define<string>(LogLevel.Information, 1, "Executing EightyViewResult<{Name}>");
    private readonly ILogger _logger;
    private readonly IHttpResponseStreamWriterFactory _writerFactory;

    /// <summary>
    /// Creates an <see cref="HtmlRendererResultExecutor{TModel}"/>
    /// </summary>
    /// <param name="loggerFactory">The logger factory</param>
    /// <param name="writerFactory">The writer factory</param>
    public HtmlRendererResultExecutor(
        ILoggerFactory loggerFactory,
        IHttpResponseStreamWriterFactory writerFactory
    )
    {
        if (loggerFactory == null)
        {
            throw new ArgumentNullException(nameof(loggerFactory));
        }
        if (writerFactory == null)
        {
            throw new ArgumentNullException(nameof(writerFactory));
        }
        _logger = loggerFactory.CreateLogger(typeof(HtmlRendererResultExecutor<>));
        _writerFactory = writerFactory;
    }

    /// <summary>
    /// Execute the <see cref="HtmlRendererResult{TModel}"/>
    /// </summary>
    /// <param name="context">The action context</param>
    /// <param name="result">The action result</param>
    public async Task ExecuteAsync(ActionContext context, HtmlRendererResult<TModel> result)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }
        if (result == null)
        {
            throw new ArgumentNullException(nameof(result));
        }

        _loggerMsg(_logger, typeof(TModel).Name, null!);

        var response = context.HttpContext.Response;

        if (result.StatusCode != null)
        {
            response.StatusCode = (int)result.StatusCode.Value;
        }
        response.ContentType = "text/html; charset=utf-8";

        var html = result.View.Render(result.Model);
        using var writer = _writerFactory.CreateWriter(response.Body, Encoding.UTF8);
        if (result.RenderAsync)
        {
            await html.WriteAsync(writer).ConfigureAwait(false);
            await writer.FlushAsync().ConfigureAwait(false);
        }
        else
        {
#pragma warning disable CA1849  // "Method synchronously blocks. Await async method instead."
            html.Write(writer);
#pragma warning restore CA1849
            await writer.FlushAsync().ConfigureAwait(false);
        }
    }
}
