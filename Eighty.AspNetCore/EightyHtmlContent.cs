using System;
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
            if (html == null)
            {
                throw new ArgumentNullException(nameof(html));
            }
            _html = html;
        }

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
}