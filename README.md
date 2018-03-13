Eighty
======

[![Build status](https://ci.appveyor.com/api/projects/status/2j85aw32h15tnthf?svg=true)](https://ci.appveyor.com/project/benjamin-hodgson/eighty)

Eighty (as in _eigh-ty-M-L_) is a simple HTML generation library. It's an embedded domain-specific language, allowing you to write C# code which roughly resembles HTML. Programming with Eighty is _just programming_: HTML is represented as ordinary immutable C# values which can be passed around as usual. This makes for an approachable alternative to Razor when you don't need the complexity of a whole templating language. It's a great fit for simple web apps or command-line tools like report generators.

```csharp
var html = article(@class: "readme")._(
    h1(id: "Eighty")._("Eighty"),
    p_(
        "Eighty (as in ",
        i_("eigh-ty-M-L"),
        ") is a simple HTML generation library."
    )
);
```

Installation
------------

Eighty is available from [Nuget](https://www.nuget.org/packages/Eighty).

Guide
-----

Almost all of Eighty's API lives in the `Html` class, which is designed to be imported with `using static`. (I like to additionally import it under an alias, to minimise line noise when you need to disambiguate something.)

```csharp
using Eighty;
using static Eighty.Html;
using H = Eighty.Html;
```

Eighty's domain-specific language adopts the following conventions:

* Tags are created using (lower-case) methods like `p()` and `i()`.
* Attributes are passed to tags as named arguments: `h1(@class: "foo")`
    * Boolean attributes like `disabled` take a `bool` as their argument, not a `string`. `button(disabled: true)` produces `<button disabled></button>`
    * Attribute names and values are HTML-encoded by default. Use the `Attr.Raw` factory method if you don't want this.
    * You can add custom attributes using tuples, or by creating an `Attr` yourself: `div(("data-example", "example"), new Attr("class", "bar"))`.
    * You can add custom Boolean attributes using the one-parameter overloads of `new Attr` and `Attr.Raw`.
* The `_` symbol means _here are the children_. `_` can appear in a few places:
    * At the end of the tag method's name. This creates a tag with no attributes. `div_(span(), img())` creates a `div` containing a `span` and an `img`.
    * As a method on a tag with attributes. `div(@class: "container")._(span(), img())` creates a `div` with a class `container`, with a `span` and an `img` inside it. Note that this means `p()._(...)` is equivalent to `p_(...)`.
    * As a top-level method name (imported statically from `Html`). This just groups together siblings. `_(span(), img())` creates a `span` and an `img` next to each other at the top level.
* You can't use `_` with self-closing tags like `img`. It doesn't have a `_` method or an `img_` variant.
* Strings are interpreted as text and are HTML-encoded: `p_("text<>")` will produce `<p>text&lt;&gt;</p>`.
    * To render a string containing raw HTML use the `Raw` method.
* All `Html` values are immutable and can be passed around as normal C# values, including being shared between different HTML documents. (Sharing as much of a tree as you can is often important for efficiency!)

To render your `Html`, use its `Write` or `WriteAsync` methods. (If you just want it as a string, you can call `ToString()`.)

```csharp
using (var writer = new StringWriter())
{
    html.Write(writer);
    Console.WriteLine(writer.ToString());
}
```


How it works
------------

Some simple tricks make this DSL's syntax work.

1. Methods like `p()` return a `TagBuilder` object, which defines the `_` method. A `TagBuilder` represents an HTML tag which is waiting for its children. Calling `_` assembles the tag and its children into an `Html` value.
    * Methods like `p_()` return an `Html` value directly. Same goes for self-closing tags like `img`
2. You can tersely combine `Html` values with other objects using implicit conversions. In particular:
    * An implicit conversion from `string` to `Html`, so you can easily mix text with markup
    * An implicit conversion from `TagBuilder` to `Html`, so you don't have to call `TagBuilder._()` when a tag doesn't have any children.
    * An implicit conversion from `(string, string)` to `Attr` to save keystrokes when using custom attributes.
3. `_` methods are declared to take `params Html[] children`. You can give a tag an arbitrary number of children, and the implicit conversions coerce each child to `Html` automatically.
4. All of the tag methods were written using code generation. There are around 25,000 lines of generated code in `Html`!


Twenty
------

Eighty comes bundled with a second HTML generation library called Twenty. Twenty is very fast (at least 5-10x faster than both Eighty and Razor in most cases) and generates no garbage, but it has a noisier syntax and is easier to misuse than Eighty. (It also can't be used with `async`.) Twenty is a good fit when you need to render HTML really fast, but you don't want to template strings or build tags by hand. I recommend starting with Eighty, and switching to Twenty if you're sure you need the extra speed.

Twenty takes an imperative view of HTML generation, wherein HTML is written directly to the output stream. (That's why it's fast.) The balancing of tags is managed by `using` statements.

To use Twenty, subclass `HtmlBuilder`. This brings the various tag methods into scope, for use in `Build`. You _must_ put the (non-self-closing) tags in `using` statements:

```csharp
using Eighty.Twenty;

class MyHtmlBuilder : HtmlBuilder
{
    protected override void Build()
    {
        using (article(@class: "readme"))
        {
            using (h1(id: "Eighty"))
                Text("Eighty");
            using (p())
            {
                Text("Eighty (as in ");
                using (i())
                    Text("eigh-ty-M-L");
                Text(") is a simple HTML generation library.");
            }
        }
    }
}
```

The tag methods like `div` write the opening tag to the output stream and then return an `IDisposable` which writes the closing tag in its `Dispose` method. It's therefore imperative (ha ha) that you don't accidentally miss out a `using` statement, as that would result in a half-closed tag! You should also avoid calling `Dispose` more than once.

It also means that `HtmlBuilder` is not thread-safe; instances of `HtmlBuilder` can only be safely accessed from one thread at a time. And it doesn't support `async`, because there's no way to implement `Dispose` asynchronously.
