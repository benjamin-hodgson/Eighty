using System.Linq;

namespace Eighty.CodeGen;

internal class EightyCodeGenerator
{
    // https://developer.mozilla.org/en-US/docs/Web/HTML/Element
    private static readonly string[] _globalAttrs
        = new[]
        {
            "id",
            "class",
            "style",
            "title",
            "tabindex",
            "contenteditable"
        };
    protected static readonly (string name, bool isSelfClosing, string[] attrs)[] _elements
        = new[]
        {
            Tag("html", "xmlns"),
            Tag("head"),
            Tag("body"),

            STag("link", "crossorigin", "rel", "href", "type", "media", "sizes"),
            STag("base", "href", "target"),
            STag("meta", "charset", "target"),
            Tag("style", "type", "media"),
            Tag("title"),
            Tag("script", "type", "src", "crossorigin", "!async"),
            Tag("noscript"),

            Tag("main"),
            Tag("header"),
            Tag("article"),
            Tag("section"),
            Tag("footer"),

            Tag("h1"),
            Tag("h2"),
            Tag("h3"),
            Tag("h4"),
            Tag("h5"),
            Tag("h6"),
            Tag("hgroup"),

            Tag("div"),
            Tag("p"),
            Tag("pre"),
            Tag("blockquote"),
            Tag("figure"),
            Tag("figcaption"),

            Tag("aside"),
            Tag("nav"),
            Tag("address"),

            Tag("a", "href", "rel", "target", "type", "download"),
            Tag("b"),
            Tag("em"),
            Tag("i"),
            Tag("mark"),
            Tag("q", "cite"),
            Tag("s"),
            Tag("small"),
            Tag("span"),
            Tag("strong"),
            Tag("sub"),
            Tag("sup"),
            Tag("u"),

            STag("br"),
            STag("wbr"),
            STag("hr"),

            Tag("abbr"),
            Tag("cite"),
            Tag("code"),
            Tag("data", "value"),
            Tag("dfn"),
            Tag("kbd"),
            Tag("samp"),
            Tag("time", "datetime"),

            Tag("ol", "type", "!reversed", "start"),
            Tag("ul", "type", "!reversed", "start"),
            Tag("li", "value"),
            Tag("dl"),
            Tag("dt"),
            Tag("dd"),

            Tag("table"),
            Tag("caption"),
            Tag("thead"),
            Tag("colgroup", "span"),
            Tag("col", "span"),
            Tag("tbody"),
            Tag("tr"),
            Tag("th", "colspan", "rowspan", "headers", "scope"),
            Tag("td", "colspan", "rowspan", "headers"),
            Tag("tfoot"),

            Tag("form", "name", "action", "method", "autocomplete", "target", "enctype", "!novalidate"),
            Tag("fieldset", "name", "!disabled", "form"),
            Tag("label", "for"),
            Tag("input",
                "name",
                "type",
                "multiple",
                "value", "placeholder", "size",
                "autocomplete", "list",
                "!autofocus", "!checked", "!disabled", "!readonly", "!required",
                "src", "height", "width",
                "max", "min", "step", "maxlength", "minlength", "pattern",
                "form", "formaction", "formmethod", "formtarget", "formenctype", "!formnovalidate"
            ),
            Tag("button",
                "name",
                "type",
                "value",
                "!autofocus", "!disabled",
                "src", "height", "width",
                "form", "formaction", "formmethod", "formtarget", "formenctype", "!formnovalidate"
            ),
            Tag("textarea",
                "name",
                "placeholder",
                "autocomplete",
                "cols", "rows", "wrap",
                "!autofocus", "!disabled", "!readonly", "!required",
                "src",
                "maxlength", "minlength",
                "form"
            ),
            Tag("datalist"),
            Tag("optgroup", "label", "!disabled"),
            Tag("select",
                "name",
                "multiple",
                "size",
                "!autofocus", "!disabled", "!required",
                "form"
            ),
            Tag("option", "label", "value", "!disabled", "!selected"),
            Tag("legend"),
            Tag("meter", "value", "form", "max", "min", "low", "high", "optimum"),
            Tag("output", "for", "name", "form"),
            Tag("progress", "value", "max"),

            Tag("menu", "type", "label"),
            Tag("menuitem",
                "type",
                "label",
                "command",
                "icon",
                "radiogroup",
                "!disabled", "!default", "!checked"
            ),
            Tag("dialog", "!open"),
            Tag("details", "!open"),
            Tag("summary"),

            STag("img", "src", "alt", "height", "width", "srcset", "sizes", "crossorigin"),
            Tag("audio", "src", "preload", "volume", "!autoplay", "!loop", "!muted", "!controls"),
            Tag("video", "src", "height", "width", "poster", "preload", "!autoplay", "!loop", "!muted", "!controls", "crossorigin"),
            STag("track", "src", "label", "kind", "!default"),

            STag("embed", "type", "src", "height", "width"),
            Tag("object", "type", "data", "height", "width", "name"),
            STag("param", "name", "value"),
            Tag("picture"),
            STag("source", "type", "src"),
            Tag("canvas", "height", "width"),

            Tag("bdi", "dir"),
            Tag("bdo", "dir"),
        };

    private static (string, bool, string[]) Tag(string name, params string[] attrs)
        => (name, false, _globalAttrs.Concat(attrs).ToArray());
    private static (string, bool, string[]) STag(string name, params string[] attrs)
        => (name, true, _globalAttrs.Concat(attrs).ToArray());

    protected static string Params(string[] attrs)
        => string.Join(',', attrs.Select(a =>
            a[0] == '!'
                ? $"\n            bool {CsId(a)} = false"
                : $"\n            string {CsId(a)} = null"
        ));

    private static readonly string[] _keywords = new[] { "class", "base", "for", "checked", "readonly", "object", "default" };
    protected static string CsId(string name)
    {
        var id = name.TrimStart('!');
        if (_keywords.Contains(id))
        {
            return "@" + id;
        }
        return id;
    }

    private static readonly string _vowels = "aeiou";
    private static readonly string _vowelSoundingLetters = "aefhilmnorsx";
    protected static string IndefiniteArticle(string noun)
        => noun == "html"
        || noun.Length <= 2 && _vowelSoundingLetters.Contains(noun[0])
        || _vowels.Contains(noun[0])
            ? "an"
            : "a";

    protected static string AttrParams(int number)
        => string.Join(", ", Enumerable.Range(1, number).Select(n => "Attr attr" + n));

    protected static string AttrArgs(int number)
        => string.Join(", ", Enumerable.Range(1, number).Select(n => "attr" + n));

    protected static string ChildParams(int number)
        => string.Join(", ", Enumerable.Range(1, number).Select(n => "Html child" + n));

    protected static string ChildArgs(int number)
        => string.Join(", ", Enumerable.Range(1, number).Select(n => "child" + n));

    protected static string CheckChildNulls(int number)
        => string.Concat(Enumerable.Range(1, number).Select(n => $@"
            if (child{n} == null)
            {{
                throw new ArgumentNullException(nameof(child{n}));
            }}"));
}
