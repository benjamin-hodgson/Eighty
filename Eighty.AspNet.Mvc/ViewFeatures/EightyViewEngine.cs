using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Eighty.Twenty;

namespace Eighty.AspNet.Mvc.ViewFeatures
{
    /// <summary>
    /// An <see cref="IViewEngine"/> implementation which can render <see cref="IHtmlRenderer{TModel}"/>s or <see cref="IHtmlBuilderRenderer{TModel}"/>s.
    /// </summary>
    public class EightyViewEngine : IViewEngine
    {
        private readonly Dictionary<string, IView> _views;

        /// <summary>
        /// Create an <see cref="EightyViewEngine"/>
        /// </summary>
        /// <param name="views">The views</param>
        public EightyViewEngine(Dictionary<string, IView> views)
        {
            _views = views;
        }

        /// <inheritdoc/>
        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            // ignore masterName... is this the right thing to do?
            return FindPartialView(controllerContext, viewName, useCache);
        }

        /// <inheritdoc/>
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            var controllerName = controllerContext.RouteData.GetRequiredString("controller");
            var path = controllerName + "/" + partialViewName;
            if (_views.TryGetValue(path, out var view))
            {
                return new ViewEngineResult(view, this);
            }
            return new ViewEngineResult(new[] { "EightyCompiledViews/" + path });
        }

        /// <inheritdoc/>
        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
            if (view is IDisposable d)
            {
                d.Dispose();
            }
        }
    }
}
