using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Eighty.Twenty;

using Xunit;

using static Eighty.Html;

using H = Eighty.Html;

namespace Eighty.Tests;

public class HtmlAsyncTests
{
    [Fact]
    public async Task Text()
    {
        H html = "hello";
        Assert.Equal("hello", await GetStringAsync(html));
    }

    [Fact]
    public async Task Text_HighAscii()
    {
        H html = ((char)232).ToString();  // "è"
        Assert.Equal("&#xE8;", await GetStringAsync(html));
    }

    [Fact]
    public async Task LongText()
    {
        {
            var expected = new string('a', 10000);
            H html = expected;
            Assert.Equal(expected, await GetStringAsync(html));
        }

        {
            var expected = string.Concat(Enumerable.Repeat("abcdefghijkl", 5000));
            H html = expected;
            Assert.Equal(expected, await GetStringAsync(html));
        }
    }

    [Fact]
    public async Task TextEscaping()
    {
        H html = "<>\"&'";
        Assert.Equal("&lt;&gt;&quot;&amp;&#x27;", await GetStringAsync(html));
    }

    [Fact]
    public async Task TextEscaping_Long()
    {
        H html = string.Concat(Enumerable.Repeat("<>\"&'", 10000));
        var expected = string.Concat(Enumerable.Repeat("&lt;&gt;&quot;&amp;&#x27;", 10000));
        Assert.Equal(expected, await GetStringAsync(html));
    }

    [Fact]
    public async Task TextEscaping_Unicode()
    {
        {
            H html = "\U0001F01C";
            Assert.Equal("&#x1F01C;", await GetStringAsync(html));
        }

        {
            H html = "\U0001F01C then some text";
            Assert.Equal("&#x1F01C; then some text", await GetStringAsync(html));
        }
    }

    [Fact]
    public async Task Text_BadSurrogatePair()
    {
        {
            // a low surrogate on its own
            H html = new string(new[] { '\xdc1c' });
            Assert.Equal("\uFFFD", await GetStringAsync(html));
        }

        {
            // a high surrogate on its own
            H html = new string(new[] { '\xd83c' });
            Assert.Equal("\uFFFD", await GetStringAsync(html));
        }

        {
            // "\U0001F01C" is '\xd83c', '\xdc1c', so flipping them produces an invalid pair
            H html = new string(new[] { '\xdc1c', '\xd83c' });
            Assert.Equal("\uFFFD\uFFFD", await GetStringAsync(html));
        }

        {
            // a single bad surrogate followed by a valid pair
            H html = new string(new[] { '\xdc1c', '\xd83c', '\xdc1c' });
            Assert.Equal("\uFFFD&#x1F01C;", await GetStringAsync(html));
        }
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
            H html = p();
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

    private class MyHtmlBuilder : HtmlBuilder
    {
        protected override void Build()
        {
            using (a())
            {
            }
        }
    }

    [Fact]
    public async Task Builder()
    {
        var html = p_(H.Builder(() => new MyHtmlBuilder()));
        using (var writer = new StringWriter())
        {
            await Assert.ThrowsAsync<InvalidOperationException>(() => html.WriteAsync(writer));
            Assert.Equal("", writer.ToString());  // shouldn't have written anything
        }
    }

    // attributes
    [Fact]
    public async Task SelfClosingTagWithAttrs()
    {
        {
            var html = img(src: "http://foo.bar.baz", title: "my image");
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

    private static async Task<string> GetStringAsync(H html)
    {
        using var writer = new StringWriter();
        await html.WriteAsync(writer);
        return writer.ToString();
    }
}
