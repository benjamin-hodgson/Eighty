using System.Collections.Immutable;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Eighty
{
    internal sealed class SelfClosingTag : Html
    {
        private readonly string _tagName;
        private readonly ImmutableArray<Attr> _attributes;

        public SelfClosingTag(string tagName, ImmutableArray<Attr> attributes)
        {
            _tagName = WebUtility.HtmlEncode(tagName);
            _attributes = attributes;
        }

        internal override void WriteImpl(TextWriter writer)
        {
            writer.Write('<');
            writer.Write(_tagName);

            foreach (var attr in _attributes)
            {
                writer.Write(' ');
                attr.Write(writer);
            }

            writer.Write("/>");
        }

        internal override async Task WriteAsyncImpl(TextWriter writer)
        {
            await writer.WriteAsync('<').ConfigureAwait(false);
            await writer.WriteAsync(_tagName).ConfigureAwait(false);

            foreach (var attr in _attributes)
            {
                await writer.WriteAsync(' ').ConfigureAwait(false);
                await attr.WriteAsync(writer).ConfigureAwait(false);
            }

            await writer.WriteAsync("/>").ConfigureAwait(false);
        }
    }
}
