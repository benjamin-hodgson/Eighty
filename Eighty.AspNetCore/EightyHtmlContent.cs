using System;
using System.IO;
using System.Text.Encodings.Web;

using Microsoft.AspNetCore.Html;

namespace Eighty.AspNetCore;

/// <summary>
/// An implementation of <see cref="IHtmlContent"/> which wraps some <see cref="Html"/>
/// </summary>
public class EightyHtmlContent : IHtmlContent
{
    private readonly Html _html;

    /// <summary>
    /// Create an <see cref="EightyHtmlContent"/>
    /// </summary>
    /// <param name="html">The HTML</param>
    public EightyHtmlContent(Html html)
    {
        if (html == null)
        {
            throw new ArgumentNullException(nameof(html));
        }
        _html = html;
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
        _html.Write(writer, encoder);
    }
}
