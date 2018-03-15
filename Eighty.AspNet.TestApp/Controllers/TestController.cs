using System.Net;
using System.Web.Mvc;
using Eighty.AspNet.Mvc.ActionResults;
using Eighty.AspNet.TestApp.Views.Test;
using static Eighty.Html;

namespace Eighty.AspNet.TestApp.Controllers
{
    public class TestController : Controller
    {
        public ActionResult HtmlResult()
        {
            return p_().ToActionResult(HttpStatusCode.PartialContent);
        }

        public ActionResult HtmlBuilderResult()
        {
            return new TestHtmlBuilder(1).ToActionResult(HttpStatusCode.PartialContent);
        }

        public ActionResult HtmlRendererResult()
        {
            return new TestHtmlRenderer().ToActionResult(1, HttpStatusCode.PartialContent);
        }

        public ActionResult HtmlBuilderRendererResult()
        {
            return new TestHtmlBuilderRenderer().ToActionResult(1, HttpStatusCode.PartialContent);
        }

        public ActionResult HtmlView()
        {
            return View(1);
        }

        public ActionResult HtmlBuilderView()
        {
            return View(1);
        }
    }
}