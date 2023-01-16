using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Eighty.AspNetCore.Mvc.ViewFeatures;

/// <summary>
/// Configures the <see cref="MvcViewOptions"/> to set up an <see cref="EightyViewEngine"/>.
/// </summary>
public class EightyMvcViewOptionsSetup : IConfigureOptions<MvcViewOptions>
{
    private readonly EightyViewEngine _viewEngine;

    /// <summary>
    /// Creates a <see cref="EightyMvcViewOptionsSetup"/>.
    /// </summary>
    /// <param name="viewEngine">The view engine.</param>
    public EightyMvcViewOptionsSetup(EightyViewEngine viewEngine)
    {
        if (viewEngine == null)
        {
            throw new ArgumentNullException(nameof(viewEngine));
        }

        _viewEngine = viewEngine;
    }

    /// <inheritdoc/>
    public void Configure(MvcViewOptions options)
    {
        if (options == null)
        {
            throw new ArgumentNullException(nameof(options));
        }

        options.ViewEngines.Add(_viewEngine);
    }
}
