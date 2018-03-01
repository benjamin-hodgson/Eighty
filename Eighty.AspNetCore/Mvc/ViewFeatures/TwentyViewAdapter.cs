using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Eighty.AspNetCore.Mvc.ViewFeatures
{
    public class TwentyViewAdapter<TModel> : IView
    {
        public string Path { get; }
        private ITwentyView<TModel> _view;

        public TwentyViewAdapter(string path, ITwentyView<TModel> view)
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

        public Task RenderAsync(ViewContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            
            if (context.ViewData.Model is TModel m)
            {
                var html = _view.GetHtmlBuilder(m);
                html.Write(context.Writer);
                return Task.CompletedTask;
            }
            throw new InvalidOperationException($"Expected a model of type {typeof(TModel).Name} but the actual model is of type {context.ViewData.Model.GetType().Name}");
        }
    }
}