using System;
using System.IO;
using System.Text.Encodings.Web;
using Eighty.Twenty;
using Microsoft.AspNetCore.Html;

namespace Eighty.AspNetCore
{
    public class TwentyHtmlContent : IHtmlContent
    {
        private readonly HtmlBuilder _builder;

        public TwentyHtmlContent(HtmlBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }
            _builder = builder;
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
            _builder.Write(writer, encoder);
        }
    }
}