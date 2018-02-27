using System;

namespace Eighty.AspNetCore.Mvc
{
    public interface IEightyView<in TModel>
    {
        Html Render(TModel model);
    }
}
