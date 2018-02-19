using System.Collections.Immutable;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Eighty
{
    internal sealed class SelfClosingTag : Html
    {
        private readonly string _name;
        private readonly ImmutableArray<Attr> _attributes;

        public SelfClosingTag(string name, ImmutableArray<Attr> attributes)
        {
            _name = name;
            _attributes = attributes;
        }

        internal override void WriteImpl(TextWriter writer)
        {
            writer.Write('<');
            writer.Write(_name);

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
            await writer.WriteAsync(_name).ConfigureAwait(false);

            foreach (var attr in _attributes)
            {
                await writer.WriteAsync(' ').ConfigureAwait(false);
                await attr.WriteAsync(writer).ConfigureAwait(false);
            }

            await writer.WriteAsync("/>").ConfigureAwait(false);
        }
    }
}
