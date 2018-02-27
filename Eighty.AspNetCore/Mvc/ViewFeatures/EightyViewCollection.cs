using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Eighty.AspNetCore.Mvc.ViewFeatures
{
    public class EightyViewCollection
    {
        internal Dictionary<string, Func<IServiceProvider, IView>> Views { get; } = new Dictionary<string, Func<IServiceProvider, IView>>();

        public void RegisterSingleton<TModel>(string controllerName, string viewName, IEightyView<TModel> view)
        {
            RegisterSingleton(controllerName + "/" + viewName, view);
        }
        public void RegisterSingleton<TModel>(string path, IEightyView<TModel> view)
        {
            var adapter = new EightyViewAdapter<TModel>(path, view);
            Views[path] = _ => adapter;
        }

        public void RegisterSingleton<TModel>(string controllerName, string viewName, ITwentyView<TModel> view)
        {
            RegisterSingleton(controllerName + "/" + viewName, view);
        }
        public void RegisterSingleton<TModel>(string path, ITwentyView<TModel> view)
        {
            var adapter = new TwentyViewAdapter<TModel>(path, view);
            Views[path] = _ => adapter;
        }
    }
}
