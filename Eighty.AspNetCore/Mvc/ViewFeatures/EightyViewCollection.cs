using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using Eighty.Twenty;

using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Eighty.AspNetCore.Mvc.ViewFeatures;

/// <summary>
/// A collection of views.
/// </summary>
[SuppressMessage("naming", "CA1711", Justification = "Purposeful")] // "Rename type name so that it does not end in 'Collection'"
public class EightyViewCollection
{
    internal Dictionary<string, Func<IServiceProvider, IView>> Views { get; } = new Dictionary<string, Func<IServiceProvider, IView>>();

    /// <summary>
    /// Add an <see cref="IHtmlRenderer{TModel}"/> to the collection.
    /// </summary>
    /// <typeparam name="TModel">The model type.</typeparam>
    /// <param name="controllerName">The controller name.</param>
    /// <param name="viewName">The view name.</param>
    /// <param name="view">The view.</param>
    public void RegisterSingleton<TModel>(string controllerName, string viewName, IHtmlRenderer<TModel> view)
    {
        RegisterSingleton(controllerName + "/" + viewName, view);
    }

    /// <summary>
    /// Add an <see cref="IHtmlRenderer{TModel}"/> to the collection.
    /// </summary>
    /// <typeparam name="TModel">The model type.</typeparam>
    /// <param name="path">The view path.</param>
    /// <param name="view">The view.</param>
    public void RegisterSingleton<TModel>(string path, IHtmlRenderer<TModel> view)
    {
        var adapter = new EightyViewAdapter<TModel>(path, view);
        Views[path] = _ => adapter;
    }

    /// <summary>
    /// Add an <see cref="IHtmlBuilderRenderer{TModel}"/> to the collection.
    /// </summary>
    /// <typeparam name="TModel">The model type.</typeparam>
    /// <param name="controllerName">The controller name.</param>
    /// <param name="viewName">The view name.</param>
    /// <param name="view">The view.</param>
    public void RegisterSingleton<TModel>(string controllerName, string viewName, IHtmlBuilderRenderer<TModel> view)
    {
        RegisterSingleton(controllerName + "/" + viewName, view);
    }

    /// <summary>
    /// Add an <see cref="IHtmlBuilderRenderer{TModel}"/> to the collection.
    /// </summary>
    /// <typeparam name="TModel">The model type.</typeparam>
    /// <param name="path">The view path.</param>
    /// <param name="view">The view.</param>
    public void RegisterSingleton<TModel>(string path, IHtmlBuilderRenderer<TModel> view)
    {
        var adapter = new TwentyViewAdapter<TModel>(path, view);
        Views[path] = _ => adapter;
    }
}
