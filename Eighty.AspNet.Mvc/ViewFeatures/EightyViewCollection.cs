using System.Collections.Generic;
using System.Web.Mvc;
using Eighty.Twenty;

namespace Eighty.AspNet.Mvc.ViewFeatures
{
    /// <summary>
    /// A collection of views
    /// </summary>
    public class EightyViewCollection
    {
        internal Dictionary<string, IView> Views { get; } = new Dictionary<string, IView>();

        /// <summary>
        /// Add an <see cref="IHtmlRenderer{TModel}"/> to the collection
        /// </summary>
        /// <param name="controllerName">The controller name</param>
        /// <param name="viewName">The view name</param>
        /// <param name="view">The view</param>
        public void RegisterSingleton<TModel>(string controllerName, string viewName, IHtmlRenderer<TModel> view)
        {
            RegisterSingleton(controllerName + "/" + viewName, view);
        }
        /// <summary>
        /// Add an <see cref="IHtmlRenderer{TModel}"/> to the collection
        /// </summary>
        /// <param name="path">The view path</param>
        /// <param name="view">The view</param>
        public void RegisterSingleton<TModel>(string path, IHtmlRenderer<TModel> view)
        {
            var adapter = new EightyViewAdapter<TModel>(path, view);
            Views[path] = adapter;
        }

        /// <summary>
        /// Add an <see cref="IHtmlBuilderRenderer{TModel}"/> to the collection
        /// </summary>
        /// <param name="controllerName">The controller name</param>
        /// <param name="viewName">The view name</param>
        /// <param name="view">The view</param>
        public void RegisterSingleton<TModel>(string controllerName, string viewName, IHtmlBuilderRenderer<TModel> view)
        {
            RegisterSingleton(controllerName + "/" + viewName, view);
        }
        /// <summary>
        /// Add an <see cref="IHtmlBuilderRenderer{TModel}"/> to the collection
        /// </summary>
        /// <param name="path">The view path</param>
        /// <param name="view">The view</param>
        public void RegisterSingleton<TModel>(string path, IHtmlBuilderRenderer<TModel> view)
        {
            var adapter = new TwentyViewAdapter<TModel>(path, view);
            Views[path] = adapter;
        }
    }
}
