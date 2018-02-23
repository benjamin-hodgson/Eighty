using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eighty.Bench.WebApp.Models;
using System.IO;
using System.Text;
using Eighty.Twenty;
using System.Collections.Immutable;

namespace Eighty.Bench.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Model _model = new Model(1000, "foo<>");

        public IActionResult Razor()
        {
            return View(_model);
        }

        public IActionResult Eighty()
        {
            return new EightyResult(new MyHtmlBuilder(_model).BuildHtml());
        }

        public IActionResult EightyAsync()
        {
            return new EightyAsyncResult(new MyHtmlBuilder(_model).BuildHtml());
        }

        public IActionResult Twenty()
        {
            return new TwentyResult(new MyHtmlBuilder(_model));
        }
    }

    class MyHtmlBuilder : HtmlBuilder
    {
        private readonly Model _model;

        public MyHtmlBuilder(Model model)
        {
            _model = model;
        }
        protected override void Build()
        {
            for (var i = 0; i < _model.Iterations; i++)
            {
                using (p(@class: _model.ClassName))
                {

                }
            }
        }

        public Html BuildHtml()
        {
            var builder = ImmutableArray.CreateBuilder<Html>(_model.Iterations);
            for (var i = 0; i < _model.Iterations; i++)
            {
                builder.Add(Eighty.Html.p(@class: _model.ClassName));
            }
            return Eighty.Html._(builder.MoveToImmutable());
        }
    }

    public class EightyAsyncResult : IActionResult
    {
        private readonly Html _html;

        public EightyAsyncResult(Html html)
        {
            _html = html;
        }
        
        public async Task ExecuteResultAsync(ActionContext context)
        {
            var response = context.HttpContext.Response;
            using (var writer = new StreamWriter(response.Body))
            {
                await _html.WriteAsync(writer).ConfigureAwait(false);
            }
        }
    }

    public class EightyResult : ActionResult
    {
        private readonly Html _html;

        public EightyResult(Html html)
        {
            _html = html;
        }
        
        public override void ExecuteResult(ActionContext context)
        {
            var response = context.HttpContext.Response;
            using (var writer = new StreamWriter(response.Body))
            {
                _html.Write(writer);
            }
        }
    }

    public class TwentyResult : ActionResult
    {
        private readonly HtmlBuilder _htmlBuilder;

        public TwentyResult(HtmlBuilder htmlBuilder)
        {
            _htmlBuilder = htmlBuilder;
        }
        public override void ExecuteResult(ActionContext context)
        {
            var response = context.HttpContext.Response;
            using (var writer = new StreamWriter(response.Body))
            {
                _htmlBuilder.Write(writer);
            }
        }
    }
}
