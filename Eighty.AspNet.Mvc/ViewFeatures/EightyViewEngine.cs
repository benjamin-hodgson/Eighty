using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Eighty.AspNet.Mvc.ViewFeatures
{
    public class EightyViewEngine : IViewEngine
    {
        private readonly Dictionary<string, IView> _views;

        public EightyViewEngine(Dictionary<string, IView> views)
        {
            _views = views;
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            // ignore masterName... is this the right thing to do?
            return FindPartialView(controllerContext, viewName, useCache);
        }

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

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
            if (view is IDisposable d)
            {
                d.Dispose();
            }
        }
    }
}
