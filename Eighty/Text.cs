using System.IO;
using System.Threading.Tasks;

namespace Eighty
{
    internal class Text : Html
    {
        private readonly string _text;

        public Text(string text) : base(true)
        {
            _text = text;
        }

        internal override void WriteImpl(ref HtmlEncodingTextWriter writer)
        {
            writer.Write(_text);
        }

        internal override Task WriteAsyncImpl(AsyncHtmlEncodingTextWriter writer)
            => writer.Write(_text);
    }
}
