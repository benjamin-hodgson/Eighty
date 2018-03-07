using System.Collections.Immutable;
using Eighty.Bench.WebApp.Models;
using static Eighty.Html;

namespace Eighty.Bench.WebApp.Views.Home
{
    public class Eighty : IHtmlRenderer<Model>
    {
        public Html Render(Model model)
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