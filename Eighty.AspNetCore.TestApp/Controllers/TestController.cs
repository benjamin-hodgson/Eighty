using System.Net;
using Microsoft.AspNetCore.Mvc;
using Eighty.AspNetCore.Mvc.ActionResults;
using Eighty.AspNetCore.TestApp.Views.Test;
using static Eighty.Html;

namespace Eighty.AspNetCore.TestApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult HtmlResult()
        {
            return p_().ToActionResult(HttpStatusCode.PartialContent);
        }
        public IActionResult AsyncHtmlResult()
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
        public IActionResult AsyncHtmlRendererResult()
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
        public IActionResult AsyncHtmlView()
        {
            ViewData["RenderAsync"] = true;
            return View("HtmlView", 1);
        }
        public IActionResult HtmlBuilderView()
        {
            return View(1);
        }
    }
}