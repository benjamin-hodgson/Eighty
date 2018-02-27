using Eighty.Twenty;

namespace Eighty.AspNetCore.Mvc
{
    public interface ITwentyView<in TModel>
    {
        HtmlBuilder GetHtmlBuilder(TModel model);
    }
}