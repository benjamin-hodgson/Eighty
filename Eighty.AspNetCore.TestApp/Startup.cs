using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eighty.AspNetCore.Mvc;
using Eighty.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Eighty.Test.WebApp
{
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
                .AddMvc()
                .AddEighty(
                    opts =>
                    {
                        opts.ViewCollection.RegisterSingleton("Bench", "Eighty", new Views.Bench.Eighty());
                        opts.ViewCollection.RegisterSingleton("Bench", "EightyAsync", new Views.Bench.Eighty());
                        opts.ViewCollection.RegisterSingleton("Bench", "Twenty", new Views.Bench.Twenty());

                        opts.ViewCollection.RegisterSingleton("Test", "HtmlView", new Views.Test.TestHtmlRenderer());
                        opts.ViewCollection.RegisterSingleton("Test", "HtmlViewAsync", new Views.Test.TestHtmlRenderer());
                        opts.ViewCollection.RegisterSingleton("Test", "HtmlBuilderView", new Views.Test.TestHtmlBuilderRenderer());
                    }
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
