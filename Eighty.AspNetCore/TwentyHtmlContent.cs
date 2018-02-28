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
            _builder = builder;
        }

        public void WriteTo(TextWriter writer, HtmlEncoder encoder)
        {
            _builder.Write(writer, encoder);
        }
    }
}