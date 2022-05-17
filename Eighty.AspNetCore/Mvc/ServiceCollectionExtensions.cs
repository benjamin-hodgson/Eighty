using System;

using Eighty.AspNetCore.Mvc.ResultExecutors;
using Eighty.AspNetCore.Mvc.ViewFeatures;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace Eighty.AspNetCore.Mvc;

/// <summary>
/// Extension methods for <see cref="IMvcBuilder"/> for configuring Eighty
/// </summary>
public static class MvcBuilderExtensions
{
    /// <summary>
    /// Configure all of Eighty's MVC features.
    /// </summary>
    /// <param name="builder">The MVC builder</param>
    /// <param name="registerEightyViews">An action to register your application's views with the <see cref="EightyViewEngine"/></param>
    /// <returns>The MVC builder</returns>
    public static IMvcBuilder AddEighty(this IMvcBuilder builder, Action<EightyViewOptions> registerEightyViews)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        builder.Services.AddSingleton(
            p => new EightyViewEngine(p.GetService<IOptions<EightyViewOptions>>().Value, p)
        );
        builder.Services.TryAddEnumerable(
            ServiceDescriptor.Transient<IConfigureOptions<MvcViewOptions>, EightyMvcViewOptionsSetup>()
        );
        builder.Services.Configure(registerEightyViews);
        builder.Services
            .AddSingleton(typeof(HtmlRendererResultExecutor<>))
            .AddSingleton(typeof(HtmlBuilderRendererResultExecutor<>))
            .AddSingleton(typeof(HtmlResultExecutor))
            .AddSingleton(typeof(HtmlBuilderResultExecutor));
        return builder;
    }
}
