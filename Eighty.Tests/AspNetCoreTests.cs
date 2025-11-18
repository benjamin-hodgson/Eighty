using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

using Eighty.AspNetCore;
using Eighty.Twenty;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;

using Xunit;

using static Eighty.Html;

namespace Eighty.Tests;

[SuppressMessage("design", "CA1001: Types that own disposable fields should be disposable", Justification = "Test code")]
[SuppressMessage("usage", "CA2234: Pass System.Uri objects instead of strings", Justification = "Test code")]
public class AspNetCoreTests
{
    private readonly TestServer _server;
    private readonly HttpClient _client;

    public AspNetCoreTests()
    {
        var host = Host.CreateDefaultBuilder()
            .ConfigureWebHost(webHostBuilder =>
            {
                webHostBuilder
                    .UseTestServer()
                    .UseStartup<AspNetCore.TestApp.Startup>()
                    .UseSolutionRelativeContentRoot("Eighty.AspNetCore.TestApp", "*.slnx");
            })
            .Build();
        host.Start();
        _server = host.GetTestServer();
        _client = _server.CreateClient();
    }

    [Fact]
    public void TestEightyHtmlContent()
    {
        var htmlContent = new EightyHtmlContent(p());

        using var writer = new StringWriter();
        htmlContent.WriteTo(writer, HtmlEncoder.Default);
        Assert.Equal("<p></p>", writer.ToString());
    }

    private sealed class MyHtmlBuilder : HtmlBuilder
    {
        protected override void Build()
        {
            using (p())
            {
            }
        }
    }

    [Fact]
    public void TestTwentyHtmlContent()
    {
        var htmlContent = new TwentyHtmlContent(new MyHtmlBuilder());

        using var writer = new StringWriter();
        htmlContent.WriteTo(writer, HtmlEncoder.Default);
        Assert.Equal("<p></p>", writer.ToString());
    }

    [Fact]
    public async Task TestHtmlResult()
    {
        {
            var response = await _client.GetAsync("Test/HtmlResult", TestContext.Current.CancellationToken);
            Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
            Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync(TestContext.Current.CancellationToken));
        }

        {
            var response = await _client.GetAsync("Test/AsyncHtmlResult", TestContext.Current.CancellationToken);
            Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
            Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync(TestContext.Current.CancellationToken));
        }
    }

    [Fact]
    public async Task TestHtmlBuilderResult()
    {
        var response = await _client.GetAsync("Test/HtmlBuilderResult", TestContext.Current.CancellationToken);
        Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
        Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync(TestContext.Current.CancellationToken));
    }

    [Fact]
    public async Task TestHtmlRendererResult()
    {
        {
            var response = await _client.GetAsync("Test/HtmlRendererResult", TestContext.Current.CancellationToken);
            Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
            Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync(TestContext.Current.CancellationToken));
        }

        {
            var response = await _client.GetAsync("Test/AsyncHtmlRendererResult", TestContext.Current.CancellationToken);
            Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
            Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync(TestContext.Current.CancellationToken));
        }
    }

    [Fact]
    public async Task TestHtmlBuilderRendererResult()
    {
        var response = await _client.GetAsync("Test/HtmlBuilderRendererResult", TestContext.Current.CancellationToken);
        Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
        Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync(TestContext.Current.CancellationToken));
    }

    [Fact]
    public async Task TestHtmlView()
    {
        {
            var response = await _client.GetAsync("Test/HtmlView", TestContext.Current.CancellationToken);
            Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync(TestContext.Current.CancellationToken));
        }

        {
            var response = await _client.GetAsync("Test/AsyncHtmlView", TestContext.Current.CancellationToken);
            Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync(TestContext.Current.CancellationToken));
        }
    }

    [Fact]
    public async Task TestHtmlBuilderView()
    {
        var response = await _client.GetAsync("Test/HtmlBuilderView", TestContext.Current.CancellationToken);
        Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync(TestContext.Current.CancellationToken));
    }
}
