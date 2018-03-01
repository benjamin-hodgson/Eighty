using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Eighty.AspNetCore.Mvc.ViewFeatures
{
    public class EightyMvcViewOptionsSetup : IConfigureOptions<MvcViewOptions>
    {
        private EightyViewEngine _viewEngine;

        public EightyMvcViewOptionsSetup(EightyViewEngine viewEngine)
        {
            if (viewEngine == null)
            {
                throw new ArgumentNullException(nameof(viewEngine));
            }
            _viewEngine = viewEngine;
        }

        public void Configure(MvcViewOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            options.ViewEngines.Add(_viewEngine);
        }
    }
}
