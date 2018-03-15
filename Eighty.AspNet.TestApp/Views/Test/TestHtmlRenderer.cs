using System.Linq;
using static Eighty.Html;

namespace Eighty.AspNet.TestApp.Views.Test
{
    class TestHtmlRenderer : IHtmlRenderer<int>
    {
        public Html Render(int model)
        {
            return _(Enumerable.Repeat(p_(), model));
        }
    }
}