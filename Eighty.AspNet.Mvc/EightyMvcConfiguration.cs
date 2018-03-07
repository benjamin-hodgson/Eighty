using System;
using System.Web.Mvc;
using Eighty.AspNet.Mvc.ViewFeatures;

namespace Eighty.AspNet.Mvc
{
    public static class EightyMvcConfiguration
    {
        public static void Configure(Action<EightyViewOptions> configure)
        {
            var options = new EightyViewOptions();
            configure(options);
            ViewEngines.Engines.Add(new EightyViewEngine(options.ViewCollection.Views));
        }
    }
}
