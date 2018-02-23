using System.Collections.Immutable;
using System.IO;
using System.Threading.Tasks;

namespace Eighty
{
    internal sealed class SelfClosingTag : Html
    {
        private readonly string _name;
        private readonly ImmutableArray<Attr> _attributes;
        private readonly bool _shouldEncodeName;

        public SelfClosingTag(string name, ImmutableArray<Attr> attributes, bool shouldEncodeName)
        {
            _name = name;
            _attributes = attributes;
            _shouldEncodeName = shouldEncodeName;
        }

        internal override void WriteImpl(ref HtmlEncodingTextWriter writer)
        {
            writer.WriteRaw('<');

            if (_shouldEncodeName)
            {
                writer.Write(_name);
            }
            else
            {
                writer.WriteRaw(_name);
            }

            foreach (var attr in _attributes)
            {
                writer.WriteRaw(' ');
                attr.Write(ref writer);
            }

            writer.WriteRaw("/>");
        }

        internal override async Task WriteAsyncImpl(AsyncHtmlEncodingTextWriter writer)
        {
            await writer.WriteRaw('<').ConfigureAwait(false);

            if (_shouldEncodeName)
            {
                await writer.Write(_name).ConfigureAwait(false);
            }
            else
            {
                await writer.WriteRaw(_name).ConfigureAwait(false);
            }

            foreach (var attr in _attributes)
            {
                await writer.WriteRaw(' ').ConfigureAwait(false);
                await attr.WriteAsync(writer).ConfigureAwait(false);
            }

            await writer.WriteRaw("/>").ConfigureAwait(false);
        }
    }
}
