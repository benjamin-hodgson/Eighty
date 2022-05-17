using System.Threading.Tasks;

namespace Eighty;

internal class Raw : Html
{
    private readonly string _rawHtml;

    public Raw(string rawHtml) : base(true)
    {
        _rawHtml = rawHtml;
    }

    internal override void WriteImpl(ref HtmlEncodingTextWriter writer)
    {
        writer.WriteRaw(_rawHtml);
    }

    internal override Task WriteAsyncImpl(AsyncHtmlEncodingTextWriter writer)
        => writer.WriteRaw(_rawHtml);
}
