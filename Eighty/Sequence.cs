using System.Collections.Immutable;
using System.IO;
using System.Threading.Tasks;

namespace Eighty
{
    internal sealed class Sequence : Html
    {
        private readonly ImmutableArray<Html> _children;

        public Sequence(ImmutableArray<Html> children)
        {
            _children = children;
        }

        internal override void WriteImpl(TextWriter writer)
        {
            foreach (var child in _children)
            {
                child.Write(writer);
            }
        }

        internal override async Task WriteAsyncImpl(TextWriter writer)
        {
            foreach (var child in _children)
            {
                await child.WriteAsync(writer).ConfigureAwait(false);
            }
        }
    }
}
