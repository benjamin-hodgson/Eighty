using Eighty.Twenty;

namespace Eighty.AspNetCore.TestApp.Views.Test;

internal class TestHtmlBuilder : HtmlBuilder
{
    private readonly int _count;

    public TestHtmlBuilder(int count)
    {
        _count = count;
    }
    protected override void Build()
    {
        for (var i = 0; i < _count; i++)
        {
            using (p()) { }
        }
    }
}
