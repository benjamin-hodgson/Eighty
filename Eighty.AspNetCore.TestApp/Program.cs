using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Eighty.Test.WebApp
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