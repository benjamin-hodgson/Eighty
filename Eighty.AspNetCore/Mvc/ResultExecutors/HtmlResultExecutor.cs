using System;
using System.Text;
using System.Threading.Tasks;

using Eighty.AspNetCore.Mvc.ActionResults;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;

namespace Eighty.AspNetCore.Mvc.ResultExecutors;

/// <summary>
/// Executes a <see cref="HtmlResult"/>
/// </summary>
public class HtmlResultExecutor
{
    private static readonly Action<ILogger, Exception> _loggerMsg = LoggerMessage.Define(LogLevel.Information, 1, "Executing HtmlResult");
    private readonly ILogger _logger;
    private readonly IHttpResponseStreamWriterFactory _writerFactory;

    /// <summary>
    /// Creates an <see cref="HtmlResultExecutor"/>
    /// </summary>
    /// <param name="logger">The logger</param>
    /// <param name="writerFactory">The writer factory</param>
    public HtmlResultExecutor(
        ILogger<HtmlResultExecutor> logger,
        IHttpResponseStreamWriterFactory writerFactory
    )
    {
        if (logger == null)
        {
            throw new ArgumentNullException(nameof(logger));
        }
        if (writerFactory == null)
        {
            throw new ArgumentNullException(nameof(writerFactory));
        }
        _logger = logger;
        _writerFactory = writerFactory;
    }

    /// <summary>
    /// Execute the <see cref="HtmlResult"/>
    /// </summary>
    /// <param name="context">The action context</param>
    /// <param name="result">The action result</param>
    public async Task ExecuteAsync(ActionContext context, HtmlResult result)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }
        if (result == null)
        {
            throw new ArgumentNullException(nameof(result));
        }

        _loggerMsg(_logger, null!);

        var response = context.HttpContext.Response;

        if (result.StatusCode != null)
        {
            response.StatusCode = (int)result.StatusCode.Value;
        }
        response.ContentType = "text/html; charset=utf-8";

        using var writer = _writerFactory.CreateWriter(response.Body, Encoding.UTF8);
        if (result.RenderAsync)
        {
            await result.Html.WriteAsync(writer).ConfigureAwait(false);
            await writer.FlushAsync().ConfigureAwait(false);
        }
        else
        {
#pragma warning disable CA1849  // "Method synchronously blocks. Await async method instead."
            result.Html.Write(writer);
#pragma warning restore CA1849
            await writer.FlushAsync().ConfigureAwait(false);
        }
    }
}
