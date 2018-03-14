using Eighty.Twenty;

namespace Eighty.Test.WebApp.Views.Test
{
    class TestHtmlBuilderRenderer : IHtmlBuilderRenderer<int>
    {
        public HtmlBuilder GetHtmlBuilder(int model)
        {
            return new TestHtmlBuilder(model);
        }
    }
}