using System;
using System.Linq;

namespace Eighty.CodeGen;

internal static class CodeGenHelpers
{
    private const string _vowels = "aeiou";
    private const string _vowelSoundingLetters = "aefhilmnorsx";

    public static string IndefiniteArticle(string noun)
        => noun == "html"
        || (noun.Length <= 2 && _vowelSoundingLetters.Contains(noun[0], StringComparison.OrdinalIgnoreCase))
        || _vowels.Contains(noun[0], StringComparison.OrdinalIgnoreCase)
            ? "an"
            : "a";

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

#pragma warning disable SA1116  // The parameters should begin on the line after the declaration, whenever the parameters span across multiple lines
#pragma warning disable SA1117  // The parameters should all be placed on the same line or each parameter should be placed on its own line.
    public static readonly (string Name, bool SelfClosing, string[] Attrs)[] Elements
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
#pragma warning restore SA1117
#pragma warning restore SA1116

    private static (string Name, bool SelfClosing, string[] Attrs) Tag(string name, params string[] attrs)
        => (name, false, _globalAttrs.Concat(attrs).ToArray());

    private static (string Name, bool SelfClosing, string[] Attrs) STag(string name, params string[] attrs)
        => (name, true, _globalAttrs.Concat(attrs).ToArray());

    public static string Params(string[] attrs)
        => string.Join(',', attrs.Select(a =>
            a[0] == '!'
                ? $"\n            bool {CsId(a)} = false"
                : $"\n            string {CsId(a)} = null"
        ));

    private static readonly string[] _keywords = new[] { "class", "base", "for", "checked", "readonly", "object", "default" };

    public static string CsId(string name)
    {
        var id = name.TrimStart('!');
        return _keywords.Contains(id)
            ? "@" + id
            : id;
    }

    public static string AttrParams(int number)
        => string.Join(", ", Enumerable.Range(1, number).Select(n => "Attr attr" + n));

    public static string AttrArgs(int number)
        => string.Join(", ", Enumerable.Range(1, number).Select(n => "attr" + n));

    public static string ChildParams(int number)
        => string.Join(", ", Enumerable.Range(1, number).Select(n => "Html child" + n));

    public static string ChildArgs(int number)
        => string.Join(", ", Enumerable.Range(1, number).Select(n => "child" + n));

    public static string CheckChildNulls(int number)
        => string.Concat(Enumerable.Range(1, number).Select(n => $@"
            if (child{n} == null)
            {{
                throw new ArgumentNullException(nameof(child{n}));
            }}"));
}
