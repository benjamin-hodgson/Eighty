using System;
using System.IO;
using System.Text.Encodings.Web;

using Eighty.Twenty;

using Microsoft.AspNetCore.Html;

namespace Eighty.AspNetCore;

/// <summary>
/// An implementation of <see cref="IHtmlContent"/> which wraps an <see cref="HtmlBuilder"/>
/// </summary>
public class TwentyHtmlContent : IHtmlContent
{
    private readonly HtmlBuilder _builder;

    /// <summary>
    /// Create a <see cref="TwentyHtmlContent"/>
    /// </summary>
    /// <param name="builder">The <see cref="HtmlBuilder"/></param>
    public TwentyHtmlContent(HtmlBuilder builder)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        _builder = builder;
    }

    /// <inheritdoc/>
    public void WriteTo(TextWriter writer, HtmlEncoder encoder)
    {
        if (writer == null)
        {
            throw new ArgumentNullException(nameof(writer));
        }
        if (encoder == null)
        {
            throw new ArgumentNullException(nameof(encoder));
        }
        _builder.Write(writer, encoder);
    }
}
