using System.Linq;

using Eighty.Twenty;

using Xunit;

using static Eighty.Html;

using H = Eighty.Html;

namespace Eighty.Tests;

public class HtmlTests
{
    [Fact]
    public void Text()
    {
        H html = "hello";
        Assert.Equal("hello", html.ToString());
    }

    [Fact]
    public void Text_HighAscii()
    {
        H html = ((char)232).ToString();  // "è"
        Assert.Equal("&#xE8;", html.ToString());
    }

    [Fact]
    public void LongText()
    {
        {
            var expected = new string('a', 10000);
            H html = expected;
            Assert.Equal(expected, html.ToString());
        }

        {
            var expected = string.Concat(Enumerable.Repeat("abcdefghijkl", 5000));
            H html = expected;
            Assert.Equal(expected, html.ToString());
        }
    }

    [Fact]
    public void TextEscaping()
    {
        H html = "<>\"&'";
        Assert.Equal("&lt;&gt;&quot;&amp;&#x27;", html.ToString());
    }

    [Fact]
    public void TextEscaping_Long()
    {
        H html = string.Concat(Enumerable.Repeat("<>\"&'", 10000));
        var expected = string.Concat(Enumerable.Repeat("&lt;&gt;&quot;&amp;&#x27;", 10000));
        Assert.Equal(expected, html.ToString());
    }

    [Fact]
    public void TextEscaping_Unicode()
    {
        {
            H html = "\U0001F01C";
            Assert.Equal("&#x1F01C;", html.ToString());
        }

        {
            H html = "\U0001F01C then some text";
            Assert.Equal("&#x1F01C; then some text", html.ToString());
        }
    }

    [Fact]
    public void Text_BadSurrogatePair()
    {
        {
            // a low surrogate on its own
            H html = new string(new[] { '\xdc1c' });
            Assert.Equal("\uFFFD", html.ToString());
        }

        {
            // a high surrogate on its own
            H html = new string(new[] { '\xd83c' });
            Assert.Equal("\uFFFD", html.ToString());
        }

        {
            // "\U0001F01C" is '\xd83c', '\xdc1c', so flipping them produces an invalid pair
            H html = new string(new[] { '\xdc1c', '\xd83c' });
            Assert.Equal("\uFFFD\uFFFD", html.ToString());
        }

        {
            // a single bad surrogate followed by a valid pair
            H html = new string(new[] { '\xdc1c', '\xd83c', '\xdc1c' });
            Assert.Equal("\uFFFD&#x1F01C;", html.ToString());
        }
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
            H html = p();
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

    private sealed class MyHtmlBuilder : HtmlBuilder
    {
        protected override void Build()
        {
            using (a())
            {
            }
        }
    }

    [Fact]
    public void Builder()
    {
        var html = p_(H.Builder(() => new MyHtmlBuilder()));
        Assert.Equal("<p><a></a></p>", html.ToString());
    }

    // attributes
    [Fact]
    public void SelfClosingTagWithAttrs()
    {
        {
            var html = img(src: "http://foo.bar.baz", title: "my image");
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
