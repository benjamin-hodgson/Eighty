using System;
using System.Collections.Immutable;

using Eighty.AspNetCore.TestApp.Models;

using static Eighty.Html;

namespace Eighty.AspNetCore.TestApp.Views.Bench;

public class EightyRenderer : IHtmlRenderer<BenchModel>
{
    public Html Render(BenchModel model)
    {
        if (model == null)
        {
            throw new ArgumentNullException(nameof(model));
        }

        var builder = ImmutableArray.CreateBuilder<Html>(model.Iterations);
        for (var i = 0; i < model.Iterations; i++)
        {
            builder.Add(p(@class: model.ClassName));
        }

        return _(builder.MoveToImmutable());
    }
}
