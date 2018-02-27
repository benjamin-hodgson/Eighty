using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Eighty.AspNetCore.Mvc.ViewFeatures
{
    public class EightyMvcViewOptionsSetup : IConfigureOptions<MvcViewOptions>
    {
        private EightyViewEngine _viewEngine;

        public EightyMvcViewOptionsSetup(EightyViewEngine viewEngine)
        {
            _viewEngine = viewEngine;
        }

        public void Configure(MvcViewOptions options)
        {
            options.ViewEngines.Add(_viewEngine);
        }
    }
}
