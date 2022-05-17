using System;
using System.Collections.Generic;

using Eighty.Twenty;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Eighty.AspNetCore.Mvc.ViewFeatures;

/// <summary>
/// An <see cref="IViewEngine"/> which can render <see cref="IHtmlRenderer{TModel}"/>s and <see cref="IHtmlBuilderRenderer{TModel}"/>s
/// </summary>
public class EightyViewEngine : IViewEngine
{
    private readonly Dictionary<string, Func<IServiceProvider, IView>> _views;
    private readonly IServiceProvider _serviceProvider;

    /// <summary>
    /// Create an <see cref="EightyViewEngine"/>
    /// </summary>
    /// <param name="options">The view options</param>
    /// <param name="serviceProvider">The service provider</param>
    public EightyViewEngine(EightyViewOptions options, IServiceProvider serviceProvider)
    {
        if (options == null)
        {
            throw new ArgumentNullException(nameof(options));
        }
        if (serviceProvider == null)
        {
            throw new ArgumentNullException(nameof(serviceProvider));
        }
        _views = options.ViewCollection.Views;
        _serviceProvider = serviceProvider;
    }

    /// <inheritdoc/>
    public ViewEngineResult FindView(ActionContext context, string viewName, bool isMainPage)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }
        if (viewName == null)
        {
            throw new ArgumentNullException(nameof(viewName));
        }
        var controllerName = RazorViewEngine.GetNormalizedRouteValue(context, "controller");
        var path = controllerName + "/" + viewName;
        if (!_views.TryGetValue(path, out var value))
        {
            return ViewEngineResult.NotFound(path, new[] { "EightyCompiledViews/" + path });
        }
        return ViewEngineResult.Found(path, value(_serviceProvider));
    }

    /// <inheritdoc/>
    public ViewEngineResult GetView(string executingFilePath, string viewPath, bool isMainPage)
    {
        if (viewPath == null)
        {
            throw new ArgumentNullException(nameof(viewPath));
        }
        if (!_views.TryGetValue(viewPath, out var value))
        {
            return ViewEngineResult.NotFound(viewPath, new[] { "EightyCompiledViews/" + viewPath });
        }
        return ViewEngineResult.Found(viewPath, value(_serviceProvider));
    }
}
