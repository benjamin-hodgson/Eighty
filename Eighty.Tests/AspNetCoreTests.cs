using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Eighty.AspNetCore;
using Eighty.Twenty;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;
using static Eighty.Html;

namespace Eighty.Tests
{
    public class AspNetCoreTests
    {
        private TestServer _server;
        private HttpClient _client;

        public AspNetCoreTests()
        {
            var path = ThisFilePath();
            var contentRoot = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(path)), "Eighty.AspNetCore.TestApp");
            _server = new TestServer(new WebHostBuilder().UseStartup<Eighty.AspNetCore.TestApp.Startup>().UseContentRoot(contentRoot));
            _client = _server.CreateClient();
        }

        private static string ThisFilePath([CallerFilePath] string filePath = null) => filePath;

        [Fact]
        public void TestEightyHtmlContent()
        {
            var htmlContent = new EightyHtmlContent(p());

            using (var writer = new StringWriter())
            {
                htmlContent.WriteTo(writer, HtmlEncoder.Default);
                Assert.Equal("<p></p>", writer.ToString());
            }
        }

        class MyHtmlBuilder : HtmlBuilder
        {
            protected override void Build()
            {
                using (p()) {}
            }
        }
        [Fact]
        public void TestTwentyHtmlContent()
        {
            var htmlContent = new TwentyHtmlContent(new MyHtmlBuilder());

            using (var writer = new StringWriter())
            {
                htmlContent.WriteTo(writer, HtmlEncoder.Default);
                Assert.Equal("<p></p>", writer.ToString());
            }
        }


        [Fact]
        public async Task TestHtmlResult()
        {
            {
                var response = await _client.GetAsync("Test/HtmlResult");
                Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
                Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync());
            }
            {
                var response = await _client.GetAsync("Test/AsyncHtmlResult");
                Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
                Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync());
            }
        }

        [Fact]
        public async Task TestHtmlBuilderResult()
        {
            var response = await _client.GetAsync("Test/HtmlBuilderResult");
            Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
            Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task TestHtmlRendererResult()
        {
            {
                var response = await _client.GetAsync("Test/HtmlRendererResult");
                Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
                Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync());
            }
            {
                var response = await _client.GetAsync("Test/AsyncHtmlRendererResult");
                Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
                Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync());
            }
        }

        [Fact]
        public async Task TestHtmlBuilderRendererResult()
        {
            var response = await _client.GetAsync("Test/HtmlBuilderRendererResult");
            Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
            Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task TestHtmlView()
        {
            {
                var response = await _client.GetAsync("Test/HtmlView");
                Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync());
            }
            {
                var response = await _client.GetAsync("Test/AsyncHtmlView");
                Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync());
            }
        }

        [Fact]
        public async Task TestHtmlBuilderView()
        {
            var response = await _client.GetAsync("Test/HtmlBuilderView");
            Assert.Equal("<p></p>", await response.Content.ReadAsStringAsync());
        }
    }
}