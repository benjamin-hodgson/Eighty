using Eighty.Twenty;

namespace Eighty.AspNetCore.TestApp.Views.Test;

internal sealed class TestHtmlBuilderRenderer : IHtmlBuilderRenderer<int>
{
    public HtmlBuilder GetHtmlBuilder(int model)
    {
        return new TestHtmlBuilder(model);
    }
}
