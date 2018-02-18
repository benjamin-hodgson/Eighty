using System.IO;
using System.Threading.Tasks;

namespace Eighty
{
    internal class Raw : Html
    {
        private string _rawHtml;

        public Raw(string rawHtml)
        {
            _rawHtml = rawHtml;
        }

        internal override void WriteImpl(TextWriter writer)
        {
            writer.Write(_rawHtml);
        }

        internal override Task WriteAsyncImpl(TextWriter writer)
            => writer.WriteAsync(_rawHtml);
    }
}
