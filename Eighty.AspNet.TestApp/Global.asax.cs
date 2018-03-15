using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Eighty.AspNet.Mvc;
using Eighty.AspNet.TestApp.Views.Test;

namespace Eighty.AspNet.TestApp
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            EightyMvcConfiguration.Configure(
                config =>
                {
                    var viewCollection = config.ViewOptions.ViewCollection;
                    viewCollection.RegisterSingleton("Test", "HtmlView", new TestHtmlRenderer());
                    viewCollection.RegisterSingleton("Test", "HtmlBuilderView", new TestHtmlBuilderRenderer());
                }
            );
        }
    }
}
