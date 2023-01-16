using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace Eighty;

internal sealed class Sequence : Html
{
    private readonly ImmutableArray<Html> _children;

    public Sequence(ImmutableArray<Html> children)
        : base(children.All(c => c.CanWriteAsync))
    {
        _children = children;
    }

    internal override void WriteImpl(ref HtmlEncodingTextWriter writer)
    {
        foreach (var child in _children)
        {
            child.WriteImpl(ref writer);
        }
    }

    internal override async Task WriteAsyncImpl(AsyncHtmlEncodingTextWriter writer)
    {
        foreach (var child in _children)
        {
            await child.WriteAsyncImpl(writer).ConfigureAwait(false);
        }
    }
}
