using System.IO;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;

namespace Eighty.AspNetCore
{
    public class EightyHtmlContent : IHtmlContent
    {
        private readonly Html _html;

        public EightyHtmlContent(Html html)
        {
            _html = html;
        }

        public void WriteTo(TextWriter writer, HtmlEncoder encoder)
        {
            _html.Write(writer, encoder);
        }
    }
}