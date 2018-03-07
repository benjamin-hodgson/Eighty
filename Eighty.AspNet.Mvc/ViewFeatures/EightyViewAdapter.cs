using System;
using System.IO;
using System.Web.Mvc;

namespace Eighty.AspNet.Mvc.ViewFeatures
{
    /// <summary>
    /// Wraps an <see cref="IHtmlRenderer{TModel}"/> into an <see cref="IView"/>
    /// </summary>
    /// <typeparam name="TModel">The model type</typeparam>
    public class EightyViewAdapter<TModel> : IView
    {
        /// <inheritdoc/>
        public string Path { get; }
        private IHtmlRenderer<TModel> _view;

        /// <summary>
        /// Creates an <see cref="EightyViewAdapter{TModel}"/>
        /// </summary>
        /// <param name="path">The view path</param>
        /// <param name="view">The view</param>
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
        public void Render(ViewContext context, TextWriter writer)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            
            if (context.ViewData.Model is TModel m)
            {
                var html = _view.Render(m);
                html.Write(writer);
                return;
            }
            throw new InvalidOperationException($"Expected a model of type {typeof(TModel).Name} but the actual model is of type {context.ViewData.Model.GetType().Name}");
        }
    }
}