using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace Eighty.Bench
{
    [InProcess]
    public class WebAppBench
    {
        private TestServer _server;
        private HttpClient _client;

        [GlobalSetup]
        public void Setup()
        {
            var path = ThisFilePath();
            var contentRoot = Path.GetDirectoryName(path) + "/../Eighty.Bench.WebApp";
            _server = new TestServer(new WebHostBuilder().UseStartup<WebApp.Startup>().UseContentRoot(contentRoot));
            _client = _server.CreateClient();
        }

        private static string ThisFilePath([CallerFilePath] string filePath = null) => filePath;

        [Benchmark(Baseline = true)]
        public async Task Razor()
        {
            await _client.GetStringAsync("/Home/Razor");
        }

        [Benchmark]
        public async Task Eighty()
        {
            await _client.GetStringAsync("/Home/Eighty");
        }

        [Benchmark]
        public async Task EightyAsync()
        {
            await _client.GetStringAsync("/Home/EightyAsync");
        }

        [Benchmark]
        public async Task Twenty()
        {
            await _client.GetStringAsync("/Home/Twenty");
        }
    }
}