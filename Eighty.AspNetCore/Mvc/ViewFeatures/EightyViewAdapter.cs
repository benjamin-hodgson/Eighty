using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Eighty.AspNetCore.Mvc.ViewFeatures
{
    public class EightyViewAdapter<TModel> : IView
    {
        public string Path { get; }
        private IEightyView<TModel> _view;

        public EightyViewAdapter(string path, IEightyView<TModel> view)
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

        public async Task RenderAsync(ViewContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            
            if (context.ViewData.Model is TModel m)
            {
                var html = _view.Render(m);

                if (context.ViewData.TryGetValue("RenderAsync", out var renderAsync) && renderAsync is bool b && b)
                {
                    await html.WriteAsync(context.Writer);
                    return;
                }
                html.Write(context.Writer);
                return;
            }
            throw new InvalidOperationException($"Expected a model of type {typeof(TModel).Name} but the actual model is of type {context.ViewData.Model.GetType().Name}");
        }
    }
}