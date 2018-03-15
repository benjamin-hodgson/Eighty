using Eighty.AspNet.Mvc;
using Eighty.Twenty;
using Xunit;
using static Eighty.Html;

namespace Eighty.AspNet.Tests
{
    public class HtmlStringTests
    {
        [Fact]
        public void TestEightyHtmlContent()
        {
            var htmlString = new EightyHtmlString(p());

            Assert.Equal("<p></p>", htmlString.ToHtmlString());
        }

        class MyHtmlBuilder : HtmlBuilder
        {
            protected override void Build()
            {
                using (p()) { }
            }
        }
        [Fact]
        public void TestTwentyHtmlContent()
        {
            var htmlString = new TwentyHtmlString(new MyHtmlBuilder());

            Assert.Equal("<p></p>", htmlString.ToHtmlString());
        }
    }
}
