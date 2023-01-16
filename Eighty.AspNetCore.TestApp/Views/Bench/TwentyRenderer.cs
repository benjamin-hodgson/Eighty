using Eighty.AspNetCore.TestApp.Models;
using Eighty.Twenty;

namespace Eighty.AspNetCore.TestApp.Views.Bench;

public class TwentyRenderer : IHtmlBuilderRenderer<BenchModel>
{
    public HtmlBuilder GetHtmlBuilder(BenchModel model)
        => new MyHtmlBuilder(model);

    private class MyHtmlBuilder : HtmlBuilder
    {
        private readonly BenchModel _model;

        public MyHtmlBuilder(BenchModel model)
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
