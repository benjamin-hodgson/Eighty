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
            var contentRoot = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(path)), "/Eighty.AspNet.TestApp");
            _server = new TestServer(new WebHostBuilder().UseStartup<Eighty.AspNetCore.TestApp.Startup>().UseContentRoot(contentRoot));
            _client = _server.CreateClient();
        }

        private static string ThisFilePath([CallerFilePath] string filePath = null) => filePath;

        [Benchmark]
        public async Task Empty()  // just measure the time to get an empty response, so can subtract from the other benchmarks
        {
            await _client.GetStringAsync("/Bench/Empty");
        }

        [Benchmark(Baseline = true)]
        public async Task Razor()
        {
            await _client.GetStringAsync("/Bench/Razor");
        }

        [Benchmark]
        public async Task Eighty()
        {
            await _client.GetStringAsync("/Bench/Eighty");
        }

        [Benchmark]
        public async Task EightyAsync()
        {
            await _client.GetStringAsync("/Bench/EightyAsync");
        }

        [Benchmark]
        public async Task Twenty()
        {
            await _client.GetStringAsync("/Bench/Twenty");
        }
    }
}