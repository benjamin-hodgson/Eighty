using System;
using System.Threading.Tasks;

using Eighty.Twenty;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Eighty.AspNetCore.Mvc.ViewFeatures;

/// <summary>
/// Wraps an <see cref="IHtmlBuilderRenderer{TModel}"/> into an <see cref="IView"/>.
/// </summary>
/// <typeparam name="TModel">The model type.</typeparam>
public class TwentyViewAdapter<TModel> : IView
{
    /// <inheritdoc/>
    public string Path { get; }

    private readonly IHtmlBuilderRenderer<TModel> _view;

    /// <summary>
    /// Creates a <see cref="TwentyViewAdapter{TModel}"/>.
    /// </summary>
    /// <param name="path">The view path.</param>
    /// <param name="view">The view.</param>
    public TwentyViewAdapter(string path, IHtmlBuilderRenderer<TModel> view)
    {
        if (path == null)
        {
            throw new ArgumentNullException(nameof(path));
        }

        if (view == null)
        {
            throw new ArgumentNullException(nameof(view));
        }

        Path = path;
        _view = view;
    }

    /// <inheritdoc/>
    public Task RenderAsync(ViewContext context)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }

        if (context.ViewData.Model is TModel m)
        {
            var html = _view.GetHtmlBuilder(m);
            html.Write(context.Writer);
            return Task.CompletedTask;
        }

        throw new InvalidOperationException($"Expected a model of type {typeof(TModel).Name} but the actual model is of type {context.ViewData.Model.GetType().Name}");
    }
}
