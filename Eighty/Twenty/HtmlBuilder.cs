using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Encodings.Web;

namespace Eighty.Twenty;

/// <summary>
/// Tools for rendering HTML imperatively.
/// </summary>
[SuppressMessage("naming", "CA1708")]  // Names of members should differ by more than case
public abstract partial class HtmlBuilder
{
    private HtmlEncodingTextWriterReference _writer;

    /// <summary>
    /// An <see cref="HtmlBuilder"/> which generates an empty HTML document
    /// </summary>
    /// <returns>An <see cref="HtmlBuilder"/> which generates an empty HTML document</returns>
    public static HtmlBuilder Null { get; } = NullHtmlBuilder.Instance;

    /// <summary>
    /// Render the HTML into a <see cref="TextWriter"/>
    /// </summary>
    /// <param name="writer">The writer</param>
    public void Write(TextWriter writer)
    {
        Write(writer, HtmlEncoder.Default);
    }

    /// <summary>
    /// Render the HTML into a <see cref="TextWriter"/>, using an <see cref="HtmlEncoder"/> to encode input text
    /// </summary>
    /// <param name="writer">The writer</param>
    /// <param name="htmlEncoder">The HTML encoder</param>
    public unsafe void Write(TextWriter writer, HtmlEncoder htmlEncoder)
    {
        if (writer == null)
        {
            throw new ArgumentNullException(nameof(writer));
        }

        if (!_writer.IsDefault())
        {
            throw new InvalidOperationException("Write is not re-entrant");
        }

        var buffer = ArrayPool<char>.Shared.Rent(4096);
        fixed (char* start = buffer)
        {
            var htmlEncodingTextWriter = new HtmlEncodingTextWriter(writer, htmlEncoder, buffer, start, buffer.Length);
            _writer = new HtmlEncodingTextWriterReference(ref htmlEncodingTextWriter);

            try
            {
                Build();
                htmlEncodingTextWriter.Flush();
            }
            finally
            {
                _writer = default;
                ArrayPool<char>.Shared.Return(buffer);
            }
        }
    }

    internal void WritePartial(ref HtmlEncodingTextWriter writer)
    {
        RenderAsPartial(new HtmlEncodingTextWriterReference(ref writer));
    }

    /// <summary>
    /// Render the HTML to a string.
    /// </summary>
    /// <returns>The HTML as a string</returns>
    public override string ToString()
    {
        using (var writer = new PooledStringWriter())
        {
            Write(writer);
            return writer.ToString();
        }
    }

    /// <summary>
    /// Write <paramref name="partial"/>'s HTML into this <see cref="HtmlBuilder"/>'s output stream.
    /// </summary>
    /// <param name="partial">The child <see cref="HtmlBuilder"/></param>
    protected void Partial(HtmlBuilder partial)
    {
        if (partial == null)
        {
            throw new ArgumentNullException(nameof(partial));
        }

        partial.RenderAsPartial(_writer);
    }

    private void RenderAsPartial(HtmlEncodingTextWriterReference writer)
    {
        if (!_writer.IsDefault())
        {
            throw new InvalidOperationException("Write is not re-entrant");
        }

        _writer = writer;

        try
        {
            Build();
        }
        finally
        {
            _writer = default;
        }
    }

    /// <summary>
    /// Write a tag which takes children.
    /// </summary>
    /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
    protected TagBuilder Tag(string name, params Attr[] attrs)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }
        if (attrs == null)
        {
            throw new ArgumentNullException(nameof(attrs));
        }
        StartTag(name);
        Attrs(attrs);
        _writer.Get().WriteRaw('>');
        return new TagBuilder(name, this, true);
    }
    /// <summary>
    /// Write a tag which takes children.
    /// </summary>
    /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
    protected TagBuilder Tag(string name, IEnumerable<Attr> attrs)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }
        if (attrs == null)
        {
            throw new ArgumentNullException(nameof(attrs));
        }
        StartTag(name);
        Attrs(attrs);
        _writer.Get().WriteRaw('>');
        return new TagBuilder(name, this, true);
    }

    /// <summary>
    /// Write a tag which does not take children.
    /// </summary>
    protected void SelfClosingTag(string name, params Attr[] attrs)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }
        if (attrs == null)
        {
            throw new ArgumentNullException(nameof(attrs));
        }
        StartTag(name);
        Attrs(attrs);
        _writer.Get().WriteRaw("/>");
    }
    /// <summary>
    /// Write a tag which does not take children.
    /// </summary>
    protected void SelfClosingTag(string name, IEnumerable<Attr> attrs)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }
        if (attrs == null)
        {
            throw new ArgumentNullException(nameof(attrs));
        }
        StartTag(name);
        Attrs(attrs);
        _writer.Get().WriteRaw("/>");
    }

    /// <summary>
    /// Write HTML-encoded text.
    /// </summary>
    /// <param name="text">The text to HTML-encode</param>
    protected internal void Text(string text)
    {
        if (text == null)
        {
            throw new ArgumentNullException(nameof(text));
        }
        _writer.Get().Write(text);
    }

    /// <summary>
    /// Render a string without HTML-encoding it first.
    /// </summary>
    /// <param name="rawHtml">The pre-encoded string</param>
    protected internal void Raw(string rawHtml)
    {
        if (rawHtml == null)
        {
            throw new ArgumentNullException(nameof(rawHtml));
        }
        _writer.Get().WriteRaw(rawHtml);
    }

    /// <summary>
    /// Write HTML.
    /// </summary>
    /// <param name="html">The HTML to write.</param>
    protected void Html(Html html)
    {
        if (html == null)
        {
            throw new ArgumentNullException(nameof(html));
        }
        html.WriteImpl(ref _writer.Get());
    }

    /// <summary>
    /// Override this method to write your HTML.
    /// </summary>
    protected abstract void Build();




    private void StartTag(string name)
    {
        _writer.Get().WriteRaw('<');
        _writer.Get().Write(name);
    }
    private void StartTagRaw(string name)
    {
        _writer.Get().WriteRaw('<');
        _writer.Get().WriteRaw(name);
    }
    private void Attrs(params Attr[] attrs)
    {
        foreach (var attr in attrs)
        {
            Attr(attr);
        }
    }
    private void Attrs(IEnumerable<Attr> attrs)
    {
        foreach (var attr in attrs)
        {
            Attr(attr);
        }
    }
    private void Attrs(Attr attr1)
    {
        Attr(attr1);
    }
    private void Attrs(Attr attr1, Attr attr2)
    {
        Attr(attr1);
        Attr(attr2);
    }
    private void Attrs(Attr attr1, Attr attr2, Attr attr3)
    {
        Attr(attr1);
        Attr(attr2);
        Attr(attr3);
    }
    private void Attrs(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
    {
        Attr(attr1);
        Attr(attr2);
        Attr(attr3);
        Attr(attr4);
    }
    private void Attrs(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
    {
        Attr(attr1);
        Attr(attr2);
        Attr(attr3);
        Attr(attr4);
        Attr(attr5);
    }
    private void Attrs(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
    {
        Attr(attr1);
        Attr(attr2);
        Attr(attr3);
        Attr(attr4);
        Attr(attr5);
        Attr(attr6);
    }
    private void Attrs(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
    {
        Attr(attr1);
        Attr(attr2);
        Attr(attr3);
        Attr(attr4);
        Attr(attr5);
        Attr(attr6);
        Attr(attr7);
    }
    private void Attrs(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
    {
        Attr(attr1);
        Attr(attr2);
        Attr(attr3);
        Attr(attr4);
        Attr(attr5);
        Attr(attr6);
        Attr(attr7);
        Attr(attr8);
    }
    private void Attr(Attr attr)
    {
        _writer.Get().WriteRaw(' ');
        attr.Write(ref _writer.Get());
    }
}
