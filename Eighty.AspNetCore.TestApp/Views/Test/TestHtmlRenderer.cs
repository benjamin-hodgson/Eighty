using System.Linq;

using static Eighty.Html;

namespace Eighty.AspNetCore.TestApp.Views.Test;

internal class TestHtmlRenderer : IHtmlRenderer<int>
{
    public Html Render(int model)
    {
        return _(Enumerable.Repeat(p_(), model));
    }
}
