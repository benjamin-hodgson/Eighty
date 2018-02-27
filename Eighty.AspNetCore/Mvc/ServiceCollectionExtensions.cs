using System;
using Eighty.AspNetCore.Mvc.ViewFeatures;
using Eighty.AspNetCore.Mvc.ResultExecutors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace Eighty.AspNetCore.Mvc
{
    public static class ServiceCollectionExtensions
    {
        public static IMvcBuilder AddEighty(this IMvcBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Services.AddSingleton<EightyViewEngine>(
                p => new EightyViewEngine(p.GetService<IOptions<EightyViewOptions>>().Value, p)
            );
            builder.Services.TryAddEnumerable(
                ServiceDescriptor.Transient<IConfigureOptions<MvcViewOptions>, EightyMvcViewOptionsSetup>()
            );
            builder.Services
                .AddSingleton(typeof(EightyViewResultExecutor<>))
                .AddSingleton(typeof(TwentyViewResultExecutor<>))
                .AddSingleton(typeof(HtmlResultExecutor))
                .AddSingleton(typeof(HtmlBuilderResultExecutor));
            return builder;
        }
    }
}