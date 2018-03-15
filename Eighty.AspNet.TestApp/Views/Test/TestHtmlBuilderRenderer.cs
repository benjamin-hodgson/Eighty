using Eighty.Twenty;

namespace Eighty.AspNet.TestApp.Views.Test
{
    class TestHtmlBuilderRenderer : IHtmlBuilderRenderer<int>
    {
        public HtmlBuilder GetHtmlBuilder(int model)
        {
            return new TestHtmlBuilder(model);
        }
    }
}