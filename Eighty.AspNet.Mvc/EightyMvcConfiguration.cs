using System;
using System.Web.Mvc;
using Eighty.AspNet.Mvc.ViewFeatures;

namespace Eighty.AspNet.Mvc
{
    /// <summary>
    /// Configures MVC for use with Eighty
    /// </summary>
    public class EightyMvcConfiguration
    {
        /// <summary>
        /// The view options
        /// </summary>
        public EightyViewConfiguration ViewOptions { get; } = new EightyViewConfiguration();

        /// <summary>
        /// Configure MVC for use with Eighty
        /// </summary>
        /// <param name="configure">An <see cref="Action{EightyViewOptions}"/> which configures the <see cref="EightyViewEngine"/>.</param>
        public static void Configure(Action<EightyMvcConfiguration> configure)
        {
            var options = new EightyMvcConfiguration();
            configure(options);
            ViewEngines.Engines.Add(new EightyViewEngine(options.ViewOptions));
        }
    }
}
