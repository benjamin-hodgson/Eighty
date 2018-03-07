using System;
using System.Web.Mvc;
using Eighty.AspNet.Mvc.ViewFeatures;

namespace Eighty.AspNet.Mvc
{
    /// <summary>
    /// Configures MVC for use with Eighty
    /// </summary>
    public static class EightyMvcConfiguration
    {
        /// <summary>
        /// Configure MVC for use with Eighty
        /// </summary>
        /// <param name="configure">An <see cref="Action{EightyViewOptions}"/> which configures the <see cref="EightyViewEngine"/>.</param>
        public static void Configure(Action<EightyViewOptions> configure)
        {
            var options = new EightyViewOptions();
            configure(options);
            ViewEngines.Engines.Add(new EightyViewEngine(options.ViewCollection.Views));
        }
    }
}
