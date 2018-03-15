using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using Xunit;

namespace Eighty.AspNet.Tests
{
    public class IntegrationTestFixture : IDisposable
    {
        private readonly Process _iisProcess;

        public IntegrationTestFixture()
        {
            var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            var iisPath = programFiles + "\\IIS Express\\iisexpress.exe";
            var appPath = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(ThisFile())), "Eighty.AspNet.TestApp");

            _iisProcess = new Process();
            _iisProcess.StartInfo.FileName = iisPath;
            _iisProcess.StartInfo.Arguments = "/path:\"" + appPath + "\" /port:8888";
            _iisProcess.Start();
        }

        public void Dispose()
        {
            _iisProcess.Kill();
        }

        private static string ThisFile([CallerFilePath] string filePath = null) => filePath;
    }

    public class IntegrationTests : IClassFixture<IntegrationTestFixture>
    {
        [Fact]
        public void TestHtmlResult()
        {
            IntegrationTest("HtmlResult");
        }

        [Fact]
        public void TestHtmlBuilderResult()
        {
            IntegrationTest("HtmlBuilderResult");
        }

        [Fact]
        public void TestHtmlRendererResult()
        {
            IntegrationTest("HtmlRendererResult");
        }

        [Fact]
        public void TestHtmlBuilderRendererResult()
        {
            IntegrationTest("HtmlBuilderRendererResult");
        }

        [Fact]
        public void TestHtmlView()
        {
            IntegrationTest("HtmlView");
        }

        [Fact]
        public void TestHtmlBuilderView()
        {
            IntegrationTest("HtmlBuilderView");
        }

        private void IntegrationTest(string actionName)
        {
            var response = (HttpWebResponse)WebRequest.CreateHttp("http://localhost:8888/Test/HtmlResult").GetResponse();

            Assert.Equal(HttpStatusCode.PartialContent, response.StatusCode);
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                Assert.Equal("<p></p>", reader.ReadToEnd());
            }
        }
    }
}
