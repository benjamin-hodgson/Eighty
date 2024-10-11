using Eighty.AspNetCore.Mvc;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Eighty.AspNetCore.TestApp;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services
            .Configure<KestrelServerOptions>(options =>
            {
                // Allow synchronous IO for HtmlEncodingTextWriter.Flush
                options.AllowSynchronousIO = true;
            })
            .AddControllersWithViews()
            .AddEighty(
                opts =>
                {
                    opts.ViewCollection.RegisterSingleton("Bench", "Eighty", new Views.Bench.EightyRenderer());
                    opts.ViewCollection.RegisterSingleton("Bench", "EightyAsync", new Views.Bench.EightyRenderer());
                    opts.ViewCollection.RegisterSingleton("Bench", "Twenty", new Views.Bench.TwentyRenderer());

                    opts.ViewCollection.RegisterSingleton("Test", "HtmlView", new Views.Test.TestHtmlRenderer());
                    opts.ViewCollection.RegisterSingleton("Test", "HtmlViewAsync", new Views.Test.TestHtmlRenderer());
                    opts.ViewCollection.RegisterSingleton("Test", "HtmlBuilderView", new Views.Test.TestHtmlBuilderRenderer());
                }
            );
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app)
    {
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
