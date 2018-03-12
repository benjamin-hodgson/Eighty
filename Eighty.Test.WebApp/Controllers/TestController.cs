using Microsoft.AspNetCore.Mvc;
using Eighty.AspNetCore.Mvc.ActionResults;
using static Eighty.Html;
using System.Net;
using Eighty.Twenty;
using System.Linq;
using Eighty.Test.WebApp.Views.Test;

namespace Eighty.Test.WebApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult HtmlResult()
        {
            return p_().ToActionResult(HttpStatusCode.PartialContent);
        }
        public IActionResult HtmlResultAsync()
        {
            return p_().ToActionResult(HttpStatusCode.PartialContent, renderAsync: true);
        }

        public IActionResult HtmlBuilderResult()
        {
            return new TestHtmlBuilder(1).ToActionResult(HttpStatusCode.PartialContent);
        }


        public IActionResult HtmlRendererResult()
        {
            return new TestHtmlRenderer().ToActionResult(1, HttpStatusCode.PartialContent);
        }
        public IActionResult HtmlRendererResultAsync()
        {
            return new TestHtmlRenderer().ToActionResult(1, HttpStatusCode.PartialContent, renderAsync: true);
        }


        public IActionResult HtmlBuilderRendererResult()
        {
            return new TestHtmlBuilderRenderer().ToActionResult(1, HttpStatusCode.PartialContent);
        }


        public IActionResult HtmlView()
        {
            return View(1);
        }
        public IActionResult HtmlViewAsync()
        {
            ViewData["RenderAsync"] = true;
            return View(1);
        }
        public IActionResult HtmlBuilderView()
        {
            return View(1);
        }
    }
}