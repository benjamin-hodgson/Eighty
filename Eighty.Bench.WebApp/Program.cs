using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Eighty.Bench.WebApp
{
    public class Program
    {
        public static void Main()
        {
            WebHost
                .CreateDefaultBuilder()
                .UseStartup<Startup>()
                .Build()
                .Run();
        }
    }
}