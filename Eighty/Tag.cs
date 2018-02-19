using System.Collections.Immutable;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Eighty
{
    internal sealed class Tag : Html
    {
        private readonly string _tagName;
        private readonly ImmutableArray<Attr> _attributes;
        private readonly ImmutableArray<Html> _children;

        public Tag(string name, ImmutableArray<Attr> attributes, ImmutableArray<Html> children)
        {
            _tagName = name;
            _attributes = attributes;
            _children = children;
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

            writer.Write('>');

            foreach (var child in _children)
            {
                child.Write(writer);
            }

            writer.Write("</");
            writer.Write(_tagName);
            writer.Write('>');
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

            await writer.WriteAsync('>').ConfigureAwait(false);

            foreach (var child in _children)
            {
                await child.WriteAsync(writer).ConfigureAwait(false);
            }

            await writer.WriteAsync("</").ConfigureAwait(false);
            await writer.WriteAsync(_tagName).ConfigureAwait(false);
            await writer.WriteAsync('>').ConfigureAwait(false);
        }
    }
}
