using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Options;

namespace Eighty.AspNetCore.Mvc.ViewFeatures
{
    public class EightyViewEngine : IViewEngine
    {
        private readonly Dictionary<string, Func<IServiceProvider, IView>> _views;
        private readonly IServiceProvider _serviceProvider;

        public EightyViewEngine(EightyViewOptions options, IServiceProvider serviceProvider)
        {
            _views = options.ViewCollection.Views;
            _serviceProvider = serviceProvider;
        }

        public ViewEngineResult FindView(ActionContext context, string viewName, bool isMainPage)
        {
            var controllerName = NormalizedRouteValue.GetNormalizedRouteValue(context, "controller");
            var path = controllerName + "/" + viewName;
            if (!_views.TryGetValue(path, out var value))
            {
                return ViewEngineResult.NotFound(path, new[] { "EightyCompiledViews/" + path });
            }
            return ViewEngineResult.Found(path, value(_serviceProvider));
        }

        public ViewEngineResult GetView(string executingFilePath, string viewPath, bool isMainPage)
        {
            if (!_views.TryGetValue(viewPath, out var value))
            {
                return ViewEngineResult.NotFound(viewPath, new[] { "EightyCompiledViews/" + viewPath });
            }
            return ViewEngineResult.Found(viewPath, value(_serviceProvider));
        }
    }
}