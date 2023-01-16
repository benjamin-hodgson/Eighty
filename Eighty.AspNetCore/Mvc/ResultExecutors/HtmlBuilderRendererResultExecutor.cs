using System;
using System.Text;
using System.Threading.Tasks;

using Eighty.AspNetCore.Mvc.ActionResults;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;

namespace Eighty.AspNetCore.Mvc.ResultExecutors;

/// <summary>
/// Executes a <see cref="HtmlBuilderRendererResult{TModel}"/>.
/// </summary>
/// <typeparam name="TModel">The model type.</typeparam>
public class HtmlBuilderRendererResultExecutor<TModel>
{
    private static readonly Action<ILogger, string, Exception> _loggerMsg = LoggerMessage.Define<string>(LogLevel.Information, 1, "Executing EightyViewResult<{Name}>");
    private readonly ILogger _logger;
    private readonly IHttpResponseStreamWriterFactory _writerFactory;

    /// <summary>
    /// Creates a <see cref="HtmlBuilderRendererResultExecutor{TModel}"/>.
    /// </summary>
    /// <param name="loggerFactory">The logger factory.</param>
    /// <param name="writerFactory">The writer factory.</param>
    public HtmlBuilderRendererResultExecutor(
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
    /// Execute the <see cref="HtmlBuilderRendererResult{TModel}"/>.
    /// </summary>
    /// <param name="context">The action context.</param>
    /// <param name="result">The action result.</param>
    /// <returns>A <see cref="Task" /> which completes when the result has executed.</returns>
    public async Task ExecuteAsync(ActionContext context, HtmlBuilderRendererResult<TModel> result)
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

        var htmlBuilder = result.View.GetHtmlBuilder(result.Model);
        using var writer = _writerFactory.CreateWriter(response.Body, Encoding.UTF8);
        htmlBuilder.Write(writer);
        await writer.FlushAsync().ConfigureAwait(false);
    }
}
