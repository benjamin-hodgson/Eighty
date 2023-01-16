using System.Diagnostics.CodeAnalysis;

namespace Eighty.Twenty;

public abstract partial class HtmlBuilder
{
    /// <summary>
    /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble.
    /// </summary>
    [SuppressMessage("naming", "IDE1006", Justification = "The method is lowercase to match the HTML tag")]
    [SuppressMessage("naming", "SA1300", Justification = "The method is lowercase to match the HTML tag")]
    protected void doctype()
    {
        Raw("<!DOCTYPE HTML>");
    }

    /// <summary>
    /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble and open the <c>&lt;html&gt;</c> tag.
    /// </summary>
    /// <returns>A <see cref="TagBuilder" /> for the <c>&lt;html&gt;</c> tag.</returns>
    [SuppressMessage("naming", "IDE1006", Justification = "The method is lowercase to match the HTML tag")]
    [SuppressMessage("naming", "SA1300", Justification = "The method is lowercase to match the HTML tag")]
    protected TagBuilder doctypeHtml()
    {
        doctype();
        return html();
    }
}
