using System;
using Xunit;
using H = Eighty.Html;
using static Eighty.Html;
using System.Threading.Tasks;
using System.IO;

namespace Eighty.Tests
{
    public class HtmlAsyncTests
    {
        [Fact]
        public async Task Text()
        {
            Html html = "hello";
            Assert.Equal("hello", await GetStringAsync(html));
        }
        [Fact]
        public async Task TextEscaping()
        {
            Html html = "<>\"";
            Assert.Equal("&lt;&gt;&quot;", await GetStringAsync(html));
        }
        [Fact]
        public async Task RawText()
        {
            var html = Raw("<>\"");
            Assert.Equal("<>\"", await GetStringAsync(html));
        }
        [Fact]
        public async Task SelfClosingTag()
        {
            var html = img();
            Assert.Equal("<img/>", await GetStringAsync(html));
        }
        [Fact]
        public async Task EmptyTag()
        {
            {
                var html = p()._();
                Assert.Equal("<p></p>", await GetStringAsync(html));
            }
            {
                var html = p_();
                Assert.Equal("<p></p>", await GetStringAsync(html));
            }
            {
                Html html = p();
                Assert.Equal("<p></p>", await GetStringAsync(html));
            }
        }
        [Fact]
        public async Task TagWithText()
        {
            {
                var html = p()._("hello");
                Assert.Equal("<p>hello</p>", await GetStringAsync(html));
            }
            {
                var html = p_("hello");
                Assert.Equal("<p>hello</p>", await GetStringAsync(html));
            }
        }
        [Fact]
        public async Task TagWithChildren()
        {
            {
                var html = p()._(a(), img());
                Assert.Equal("<p><a></a><img/></p>", await GetStringAsync(html));
            }
            {
                var html = p_(a(), img());
                Assert.Equal("<p><a></a><img/></p>", await GetStringAsync(html));
            }

            // exercise the ImmutableArrayFactory
            {
                var html = p()._(img(), img(), img(), img(), img(), img(), img(), img());
                Assert.Equal("<p><img/><img/><img/><img/><img/><img/><img/><img/></p>", await GetStringAsync(html));
            }
            {
                var html = p_(img(), img(), img(), img(), img(), img(), img(), img());
                Assert.Equal("<p><img/><img/><img/><img/><img/><img/><img/><img/></p>", await GetStringAsync(html));
            }

            // exercise the params overload
            {
                var html = p()._(img(), img(), img(), img(), img(), img(), img(), img(), img());
                Assert.Equal("<p><img/><img/><img/><img/><img/><img/><img/><img/><img/></p>", await GetStringAsync(html));
            }
            {
                var html = p_(img(), img(), img(), img(), img(), img(), img(), img(), img());
                Assert.Equal("<p><img/><img/><img/><img/><img/><img/><img/><img/><img/></p>", await GetStringAsync(html));
            }
        }
        [Fact]
        public async Task Siblings()
        {
            {
                var html = _(a(), img());
                Assert.Equal("<a></a><img/>", await GetStringAsync(html));
            }

            // exercise the params overload
            {
                var html = _(img(), img(), img(), img(), img(), img(), img(), img(), img());
                Assert.Equal("<img/><img/><img/><img/><img/><img/><img/><img/><img/>", await GetStringAsync(html));
            }
        }

        // attributes

        [Fact]
        public async Task SelfClosingTagWithAttrs()
        {
            {
                var html = img(src:"http://foo.bar.baz", title: "my image");
                Assert.Equal("<img title=\"my image\" src=\"http://foo.bar.baz\"/>", await GetStringAsync(html));
            }
            {
                var html = img(("src", "http://foo.bar.baz"), ("title", "my image"));
                Assert.Equal("<img src=\"http://foo.bar.baz\" title=\"my image\"/>", await GetStringAsync(html));
            }

            // exercise the ImmutableArrayFactory
            {
                var html = img(("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"));
                Assert.Equal("<img x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\"/>", await GetStringAsync(html));
            }

            // exercise the params overload
            {
                var html = img(("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"), ("x", "y"));
                Assert.Equal("<img x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\" x=\"y\"/>", await GetStringAsync(html));
            }
        }
        [Fact]
        public async Task EmptyTagWithAttrs()
        {
            {
                var html = p(title: "my paragraph", @class: "foo")._();
                Assert.Equal("<p class=\"foo\" title=\"my paragraph\"></p>", await GetStringAsync(html));
            }
            {
                var html = p(("title", "my paragraph"), ("class", "foo"))._();
                Assert.Equal("<p title=\"my paragraph\" class=\"foo\"></p>", await GetStringAsync(html));
            }
        }
        [Fact]
        public async Task BooleanAttrs()
        {
            {
                var html = button(disabled: false)._();
                Assert.Equal("<button></button>", await GetStringAsync(html));
            }
            {
                var html = button(disabled: true)._();
                Assert.Equal("<button disabled></button>", await GetStringAsync(html));
            }
            {
                var html = button(new Attr("disabled"))._();
                Assert.Equal("<button disabled></button>", await GetStringAsync(html));
            }
        }
        [Fact]
        public async Task AttrEscaping()
        {
            {
                var html = p(title: "<>\"")._();
                Assert.Equal("<p title=\"&lt;&gt;&quot;\"></p>", await GetStringAsync(html));
            }
            {
                var html = p(("title", "<>\""), ("<>\"", "<>\""))._();
                Assert.Equal("<p title=\"&lt;&gt;&quot;\" &lt;&gt;&quot;=\"&lt;&gt;&quot;\"></p>", await GetStringAsync(html));
            }
        }
        [Fact]
        public async Task BooleanAttrEscaping()
        {
            {
                var html = button(new Attr("<>\""))._();
                Assert.Equal("<button &lt;&gt;&quot;></button>", await GetStringAsync(html));
            }
        }
        [Fact]
        public async Task AttrRaw()
        {
            {
                var html = p(Attr.Raw("<>\"", "<>\""))._();
                Assert.Equal("<p <>\"=\"<>\"\"></p>", await GetStringAsync(html));
            }
        }
        [Fact]
        public async Task BooleanAttrRaw()
        {
            {
                var html = button(Attr.Raw("<>\""))._();
                Assert.Equal("<button <>\"></button>", await GetStringAsync(html));
            }
        }

        private async Task<string> GetStringAsync(Html html)
        {
            using (var writer = new StringWriter())
            {
                await html.WriteAsync(writer);
                return writer.ToString();
            }
        }
    }
}
