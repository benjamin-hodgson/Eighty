using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Eighty
{
    internal sealed class Tag : Html
    {
        private readonly string _tagName;
        private readonly ImmutableArray<Attr> _attributes;
        private readonly ImmutableArray<Html> _children;
        private readonly bool _shouldEncodeName;

        public Tag(string name, ImmutableArray<Attr> attributes, ImmutableArray<Html> children, bool shouldEncodeName) : base(children.All(c => c.CanWriteAsync))
        {
            _tagName = name;
            _attributes = attributes;
            _children = children;
            _shouldEncodeName = shouldEncodeName;
        }

        internal override void WriteImpl(ref HtmlEncodingTextWriter writer)
        {
            writer.WriteRaw('<');

            if (_shouldEncodeName)
            {
                writer.Write(_tagName);
            }
            else
            {
                writer.WriteRaw(_tagName);
            }

            foreach (var attr in _attributes)
            {
                writer.WriteRaw(' ');
                attr.Write(ref writer);
            }

            writer.WriteRaw('>');

            foreach (var child in _children)
            {
                child.WriteImpl(ref writer);
            }

            writer.WriteRaw("</");
            writer.Write(_tagName);
            writer.WriteRaw('>');
        }

        internal override async Task WriteAsyncImpl(AsyncHtmlEncodingTextWriter writer)
        {
            await writer.WriteRaw('<').ConfigureAwait(false);

            if (_shouldEncodeName)
            {
                await writer.Write(_tagName).ConfigureAwait(false);
            }
            else
            {
                await writer.WriteRaw(_tagName).ConfigureAwait(false);
            }

            foreach (var attr in _attributes)
            {
                await writer.WriteRaw(' ').ConfigureAwait(false);
                await attr.WriteAsync(writer).ConfigureAwait(false);
            }

            await writer.WriteRaw('>').ConfigureAwait(false);

            foreach (var child in _children)
            {
                await child.WriteAsyncImpl(writer).ConfigureAwait(false);
            }

            await writer.WriteRaw("</").ConfigureAwait(false);
            await writer.Write(_tagName).ConfigureAwait(false);
            await writer.WriteRaw('>').ConfigureAwait(false);
        }
    }
}
