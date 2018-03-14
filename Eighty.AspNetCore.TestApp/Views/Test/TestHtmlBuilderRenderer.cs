using Eighty.Twenty;

namespace Eighty.AspNetCore.TestApp.Views.Test
{
    class TestHtmlBuilderRenderer : IHtmlBuilderRenderer<int>
    {
        public HtmlBuilder GetHtmlBuilder(int model)
        {
            return new TestHtmlBuilder(model);
        }
    }
}