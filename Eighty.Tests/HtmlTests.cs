using System;
using Xunit;
using H = Eighty.Html;
using static Eighty.Html;

namespace Eighty.Tests
{
    public class HtmlTests
    {
        [Fact]
        public void TestHtml()
        {
            var html = doctypeHtml_(
                head_(
                    title_("My nice web page <>"),
                    link(rel: "stylesheet", type: "text/css", href: "/all.css")
                ),
                body_(
                    h1_("the top heading"),
                    p(@class: "foo-bar baz")._(
                        "some text ",
                        i_("italics"),
                        " more text"
                    )
                )
            );

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

            Assert.Equal(expected, html.ToString());
        }
    }
}
