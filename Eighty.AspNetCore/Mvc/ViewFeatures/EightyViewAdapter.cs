using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Eighty.AspNetCore.Mvc.ViewFeatures;

/// <summary>
/// Wraps an <see cref="IHtmlRenderer{TModel}"/> into an <see cref="IView"/>.
/// </summary>
/// <typeparam name="TModel">The model type.</typeparam>
public class EightyViewAdapter<TModel> : IView
{
    /// <inheritdoc/>
    public string Path { get; }

    private readonly IHtmlRenderer<TModel> _view;

    /// <summary>
    /// Creates an <see cref="EightyViewAdapter{TModel}"/>.
    /// </summary>
    /// <param name="path">The view path.</param>
    /// <param name="view">The view.</param>
    public EightyViewAdapter(string path, IHtmlRenderer<TModel> view)
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
    public async Task RenderAsync(ViewContext context)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }

        if (context.ViewData.Model is TModel m)
        {
            var html = _view.Render(m);

            if (context.ViewData.TryGetValue("RenderAsync", out var renderAsync) && renderAsync is bool b && b)
            {
                await html.WriteAsync(context.Writer).ConfigureAwait(false);
                return;
            }
#pragma warning disable CA1849  // "Method synchronously blocks. Await async method instead."
            html.Write(context.Writer);
#pragma warning restore CA1849
            return;
        }

        throw new InvalidOperationException($"Expected a model of type {typeof(TModel).Name} but the actual model is of type {context.ViewData.Model.GetType().Name}");
    }
}
