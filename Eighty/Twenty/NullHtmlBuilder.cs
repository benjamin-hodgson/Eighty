namespace Eighty.Twenty;

internal class NullHtmlBuilder : HtmlBuilder
{
    private NullHtmlBuilder() { }

    protected override void Build() { }

    public static HtmlBuilder Instance { get; } = new NullHtmlBuilder();
}
