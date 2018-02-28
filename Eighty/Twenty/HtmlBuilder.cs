using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;

namespace Eighty.Twenty
{
    /// <summary>
    /// Tools for rendering HTML imperatively.
    /// </summary>
    public abstract partial class HtmlBuilder
    {
        private HtmlEncodingTextWriter _writer;  // mutable struct, must not be readonly
        private HtmlBuilder _parent;

        private ref HtmlEncodingTextWriter Writer
        {
            get
            {
                if (_parent != null)
                {
                    return ref _parent.Writer;
                }
                return ref _writer;
            }
        }

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
        public void Write(TextWriter writer, HtmlEncoder htmlEncoder)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (!_writer.IsDefault() || _parent != null)
            {
                throw new InvalidOperationException("Write is not re-entrant");
            }

            _writer = new HtmlEncodingTextWriter(writer, htmlEncoder);
            
            try
            {
                Build();
                _writer.FlushAndClear();
            }
            finally
            {
                _writer = default;
            }
        }

        /// <summary>
        /// Render the HTML to a string.
        /// </summary>
        /// <returns>The HTML as a string</returns>
        public override string ToString()
        {
            using (var writer = new StringWriter())
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
            
            partial.RenderAsPartial(this);
        }

        private void RenderAsPartial(HtmlBuilder parent)
        {
            if (!_writer.IsDefault() || _parent != null)
            {
                throw new InvalidOperationException("Write is not re-entrant");
            }

            _parent = parent;

            try
            {
                Build();
            }
            finally
            {
                _parent = null;
            }
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, params Attr[] attrs)
        {
            StartTag(name);
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder(name, this, true);
        }
        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, IEnumerable<Attr> attrs)
        {
            StartTag(name);
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder(name, this, true);
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, params Attr[] attrs)
        {
            StartTag(name);
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, IEnumerable<Attr> attrs)
        {
            StartTag(name);
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write HTML-encoded text.
        /// </summary>
        /// <param name="text">The text to HTML-encode</param>
        protected internal void Text(string text)
        {
            Writer.Write(text);
        }

        /// <summary>
        /// Render a string without HTML-encoding it first.
        /// </summary>
        /// <param name="rawHtml">The pre-encoded string</param>
        protected internal void Raw(string rawHtml)
        {
            Writer.WriteRaw(rawHtml);
        }

        /// <summary>
        /// Write HTML.
        /// </summary>
        /// <param name="html">The HTML to write.</param>
        protected void Html(Html html)
        {
            html.WriteImpl(ref Writer);
        }

        /// <summary>
        /// Override this method to write your HTML.
        /// </summary>
        protected abstract void Build();




        private void StartTag(string name)
        {
            Writer.WriteRaw('<');
            Writer.Write(name);
        }
        private void StartTagRaw(string name)
        {
            Writer.WriteRaw('<');
            Writer.WriteRaw(name);
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
            Writer.WriteRaw(' ');
            attr.Write(ref Writer);
        }
    }
}
