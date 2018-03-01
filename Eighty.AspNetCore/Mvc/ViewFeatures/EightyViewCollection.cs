using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Eighty.AspNetCore.Mvc.ViewFeatures
{
    /// <summary>
    /// A collection of views
    /// </summary>
    public class EightyViewCollection
    {
        internal Dictionary<string, Func<IServiceProvider, IView>> Views { get; } = new Dictionary<string, Func<IServiceProvider, IView>>();

        /// <summary>
        /// Add an <see cref="IEightyView{TModel}"/> to the collection
        /// </summary>
        /// <param name="controllerName">The controller name</param>
        /// <param name="viewName">The view name</param>
        /// <param name="view">The view</param>
        public void RegisterSingleton<TModel>(string controllerName, string viewName, IEightyView<TModel> view)
        {
            RegisterSingleton(controllerName + "/" + viewName, view);
        }
        /// <summary>
        /// Add an <see cref="IEightyView{TModel}"/> to the collection
        /// </summary>
        /// <param name="path">The view path</param>
        /// <param name="view">The view</param>
        public void RegisterSingleton<TModel>(string path, IEightyView<TModel> view)
        {
            var adapter = new EightyViewAdapter<TModel>(path, view);
            Views[path] = _ => adapter;
        }

        /// <summary>
        /// Add an <see cref="ITwentyView{TModel}"/> to the collection
        /// </summary>
        /// <param name="controllerName">The controller name</param>
        /// <param name="viewName">The view name</param>
        /// <param name="view">The view</param>
        public void RegisterSingleton<TModel>(string controllerName, string viewName, ITwentyView<TModel> view)
        {
            RegisterSingleton(controllerName + "/" + viewName, view);
        }
        /// <summary>
        /// Add an <see cref="ITwentyView{TModel}"/> to the collection
        /// </summary>
        /// <param name="path">The view path</param>
        /// <param name="view">The view</param>
        public void RegisterSingleton<TModel>(string path, ITwentyView<TModel> view)
        {
            var adapter = new TwentyViewAdapter<TModel>(path, view);
            Views[path] = _ => adapter;
        }
    }
}
