using Eighty.Bench.WebApp.Models;
using Eighty.Twenty;

namespace Eighty.Bench.WebApp.Views.Home
{
    public class Twenty : IHtmlBuilderRenderer<Model>
    {
        public HtmlBuilder GetHtmlBuilder(Model model)
            => new MyHtmlBuilder(model);

        class MyHtmlBuilder : HtmlBuilder
        {
            private readonly Model _model;

            public MyHtmlBuilder(Model model)
            {
                _model = model;
            }
            protected override void Build()
            {
                for (var i = 0; i < _model.Iterations; i++)
                {
                    using (p(@class: _model.ClassName))
                    {

                    }
                }
            }
        }
    }
}