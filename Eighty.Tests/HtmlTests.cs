using System;
using Xunit;
using H = Eighty.Html;
using static Eighty.Html;

namespace Eighty.Tests
{
    public class HtmlTests
    {
        [Fact]
        public void Text()
        {
            Html html = "hello";
            Assert.Equal("hello", html.ToString());
        }
        [Fact]
        public void Text_HighAscii()
        {
            var expected = ((char)232).ToString();  // "è"
            Html html = expected;
            Assert.Equal(expected, html.ToString());
        }
        [Fact]
        public void LongText()
        {
            var expected = new string('a', 5000);
            Html html = expected;
            Assert.Equal(expected, html.ToString());
        }
        [Fact]
        public void TextEscaping()
        {
            Html html = "<>\"&'";
            Assert.Equal("&lt;&gt;&quot;&amp;&#39;", html.ToString());
        }
        [Fact]
        public void TextEscaping_Unicode()
        {
            Html html = "\U0001F01C";
            Assert.Equal("&#127004;", html.ToString());
        }
        [Fact]
        public void RawText()
        {
            var html = Raw("<>\"");
            Assert.Equal("<>\"", html.ToString());
        }
        [Fact]
        public void SelfClosingTag()
        {
            var html = img();
            Assert.Equal("<img/>", html.ToString());
        }
        [Fact]
        public void EmptyTag()
        {
            {
                var html = p()._();
                Assert.Equal("<p></p>", html.ToString());
            }
            {
                var html = p_();
                Assert.Equal("<p></p>", html.ToString());
            }
            {
                Html html = p();
                Assert.Equal("<p></p>", html.ToString());
            }
        }
        [Fact]
        public void TagWithText()
        {
            {
                var html = p()._("hello");
                Assert.Equal("<p>hello</p>", html.ToString());
            }
            {
                var html = p_("hello");
                Assert.Equal("<p>hello</p>", html.ToString());
            }
        }
        [Fact]
        public void TagWithChildren()
        {
            {
                var html = p()._(a(), img());
                Assert.Equal("<p><a></a><img/></p>", html.ToString());
            }
            {
                var html = p_(a(), img());
                Assert.Equal("<p><a></a><img/></p>", html.ToString());
            }

            // exercise the ImmutableArrayFactory
            {
                var html = p()._(img(), img(), img(), img(), img(), img(), img(), img());
                Assert.Equal("<p><img/><img/><img/><img/><img/><img/><img/><img/></p>", html.ToString());
            }
            {
                var html = p_(img(), img(), img(), img(), img(), img(), img(), img());
                Assert.Equal("<p><img/><img/><img/><img/><img/><img/><img/><img/></p>", html.ToString());
            }

            // exercise the params overload
            {
                var html = p()._(img(), img(), img(), img(), img(), img(), img(), img(), img());
                Assert.Equal("<p><img/><img/><img/><img/><img/><img/><img/><img/><img/></p>", html.ToString());
            }
            {
                var html = p_(img(), img(), img(), img(), img(), img(), img(), img(), img());
                Assert.Equal("<p><img/><img/><img/><img/><img/><img/><img/><img/><img/></p>", html.ToString());
            }
        }
        [Fact]
        public void Siblings()
        {
            {
                var html = _(a(), img());
                Assert.Equal("<a></a><img/>", html.ToString());
            }

            // exercise the params overload
            {
                var html = _(img(), img(), img(), img(), img(), img(), img(), img(), img());
                Assert.Equal("<img/><img/><img/><img/><img/><img/><img/><img/><img/>", html.ToString());
            }
        }

        // attributes

        [Fact]
        public void SelfClosingTagWithAttrs()
        {
            {
                var html = img(src:"http://foo.bar.baz", title: "my image");
                Assert.Equal("<img title=\"my image\" src=\"http://foo.bar.baz\"/>", html.ToString());
            }
            {
                var html = img(("src", "http://foo.bar.baz"), ("title", "my image"));
                Assert.Equal("<img src=\"http://foo.bar.baz\" title=\"my image\"/>", html.ToString());
            }

            // exercise the ImmutableArrayFactory
            {
                var html = img(("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"));
                Assert.Equal("<img x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\"/>", html.ToString());
            }

            // exercise the params overload
            {
                var html = img(("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"));
                Assert.Equal("<img x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\"/>", html.ToString());
            }
        }
        [Fact]
        public void EmptyTagWithAttrs()
        {
            {
                var html = p(title: "my paragraph", @class: "foo")._();
                Assert.Equal("<p class=\"foo\" title=\"my paragraph\"></p>", html.ToString());
            }
            {
                var html = p(("title", "my paragraph"), ("class", "foo"))._();
                Assert.Equal("<p title=\"my paragraph\" class=\"foo\"></p>", html.ToString());
            }
        }
        [Fact]
        public void BooleanAttrs()
        {
            {
                var html = button(disabled: false)._();
                Assert.Equal("<button></button>", html.ToString());
            }
            {
                var html = button(disabled: true)._();
                Assert.Equal("<button disabled></button>", html.ToString());
            }
            {
                var html = button(new Attr("disabled"))._();
                Assert.Equal("<button disabled></button>", html.ToString());
            }
        }
        [Fact]
        public void AttrEscaping()
        {
            {
                var html = p(title: "<>\"")._();
                Assert.Equal("<p title=\"&lt;&gt;&quot;\"></p>", html.ToString());
            }
            {
                var html = p(("title", "<>\""), ("<>\"", "<>\""))._();
                Assert.Equal("<p title=\"&lt;&gt;&quot;\" &lt;&gt;&quot;=\"&lt;&gt;&quot;\"></p>", html.ToString());
            }
        }
        [Fact]
        public void BooleanAttrEscaping()
        {
            {
                var html = button(new Attr("<>\""))._();
                Assert.Equal("<button &lt;&gt;&quot;></button>", html.ToString());
            }
        }
        [Fact]
        public void AttrRaw()
        {
            {
                var html = p(Attr.Raw("<>\"", "<>\""))._();
                Assert.Equal("<p <>\"=\"<>\"\"></p>", html.ToString());
            }
        }
        [Fact]
        public void BooleanAttrRaw()
        {
            {
                var html = button(Attr.Raw("<>\""))._();
                Assert.Equal("<button <>\"></button>", html.ToString());
            }
        }
    }
}
