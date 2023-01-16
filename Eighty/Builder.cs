using System;
using System.Threading.Tasks;

using Eighty.Twenty;

namespace Eighty;

internal class Builder : Html
{
    private readonly Func<HtmlBuilder> _builderFactory;

    public Builder(Func<HtmlBuilder> builderFactory)
        : base(false)
    {
        _builderFactory = builderFactory;
    }

    internal override void WriteImpl(ref HtmlEncodingTextWriter writer)
    {
        var builder = _builderFactory();
        if (builder == null)
        {
            throw new InvalidOperationException("Builder factory cannot return null");
        }

        builder.WritePartial(ref writer);
    }

    internal override Task WriteAsyncImpl(AsyncHtmlEncodingTextWriter writer)
    {
        throw new InvalidOperationException("Can't run an HtmlBuilder asynchronously");
    }
}
