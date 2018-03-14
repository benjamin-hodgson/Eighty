using System.Collections.Immutable;
using Eighty.Test.WebApp.Models;
using static Eighty.Html;

namespace Eighty.Test.WebApp.Views.Bench
{
    public class Eighty : IHtmlRenderer<BenchModel>
    {
        public Html Render(BenchModel model)
        {
            var builder = ImmutableArray.CreateBuilder<Html>(model.Iterations);
            for (var i = 0; i < model.Iterations; i++)
            {
                builder.Add(p(@class: model.ClassName));
            }
            return _(builder.MoveToImmutable());
        }
    }
}