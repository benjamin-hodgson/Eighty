using System;
using Xunit;
using System.IO;
using Eighty.Twenty;

namespace Eighty.Tests
{
    public class HtmlBuilderTests
    {
        private class MyHtmlBuilder : HtmlBuilder
        {
            protected override void Build()
            {
                using (doctypeHtml())
                {
                    using (head())
                    {
                        using (title())
                            Text("My nice web page <>");
                        link(rel: "stylesheet", type: "text/css", href: "/all.css");
                    }
                    using (body())
                    {
                        using (h1())
                            Text("the top heading");
                        using (p(@class: "foo-bar baz"))
                        {
                            Text("some text ");
                            using (i())
                                Text("italics");
                            Text(" more text");
                        }
                    }
                }
            }
        }

        [Fact]
        public void TestHtml()
        {
            var expected =
                "<!DOCTYPE HTML>" +
                "<html>" +
                    "<head>" +
                        "<title>My nice web page &lt;&gt;</title>" +
                        "<link rel=\"stylesheet\" href=\"/all.css\" type=\"text/css\"/>" +
                    "</head>" +
                    "<body>" +
                        "<h1>the top heading</h1>" +
                            "<p class=\"foo-bar baz\">" +
                                "some text <i>italics</i> more text" +
                            "</p>" +
                    "</body>" +
                "</html>";

            using (var writer = new StringWriter())
            {
                new MyHtmlBuilder().Write(writer);
                Assert.Equal(expected, writer.ToString());
            }
        }


        class TestPartial_HtmlBuilder1 : HtmlBuilder
        {
            protected override void Build()
            {
                using (p())
                {
                    Partial(new TestPartial_HtmlBuilder2());
                }
            }
        }
        class TestPartial_HtmlBuilder2 : HtmlBuilder
        {
            protected override void Build()
            {
                using (a())
                {
                    Text("in partial");
                }
            }
        }
        [Fact]
        public void TestPartial()
        {
            using (var writer = new StringWriter())
            {
                new TestPartial_HtmlBuilder1().Write(writer);
                Assert.Equal("<p><a>in partial</a></p>", writer.ToString());
            }
        }
    }
}
