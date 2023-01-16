using System;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using BenchmarkDotNet.Attributes;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace Eighty.Bench;

[InProcess]
public class WebAppBench : IDisposable
{
    private TestServer? _server;
    private HttpClient? _client;

    [GlobalSetup]
    public void Setup()
    {
        var path = ThisFilePath();
        var contentRoot = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(path))!, "Eighty.AspNetCore.TestApp");
        _server = new TestServer(new WebHostBuilder().UseStartup<AspNetCore.TestApp.Startup>().UseContentRoot(contentRoot));
        _client = _server.CreateClient();
    }

    private static string? ThisFilePath([CallerFilePath] string? filePath = null) => filePath;

    [Benchmark]
    public async Task Empty() // just measure the time to get an empty response, so can subtract from the other benchmarks
    {
        await _client!.GetStringAsync("/Bench/Empty").ConfigureAwait(false);
    }

    [Benchmark(Baseline = true)]
    public async Task Razor()
    {
        await _client!.GetStringAsync("/Bench/Razor").ConfigureAwait(false);
    }

    [Benchmark]
    public async Task Eighty()
    {
        await _client!.GetStringAsync("/Bench/Eighty").ConfigureAwait(false);
    }

    [Benchmark]
    public async Task EightyAsync()
    {
        await _client!.GetStringAsync("/Bench/EightyAsync").ConfigureAwait(false);
    }

    [Benchmark]
    public async Task Twenty()
    {
        await _client!.GetStringAsync("/Bench/Twenty").ConfigureAwait(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _server?.Dispose();
            _client?.Dispose();
        }
    }
}
