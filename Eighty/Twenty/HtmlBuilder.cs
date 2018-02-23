using System;
using System.Collections.Generic;
using System.IO;

namespace Eighty.Twenty
{
    /// <summary>
    /// Tools for rendering HTML imperatively.
    /// </summary>
    public abstract partial class HtmlBuilder
    {
        private HtmlEncodingTextWriter _writer = default;

        /// <summary>
        /// Render the HTML into a <see cref="TextWriter"/>
        /// </summary>
        /// <param name="writer">The writer</param>
        public void Write(TextWriter writer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (!_writer.IsDefault())
            {
                throw new InvalidOperationException("Write is not re-entrant");
            }

            _writer = new HtmlEncodingTextWriter(writer);
            
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
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, params Attr[] attrs)
        {
            StartTag(name);
            Attrs(attrs);
            _writer.WriteRaw('>');
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
            _writer.WriteRaw('>');
            return new TagBuilder(name, this, true);
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, params Attr[] attrs)
        {
            StartTag(name);
            Attrs(attrs);
            _writer.WriteRaw("/>");
        }
        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, IEnumerable<Attr> attrs)
        {
            StartTag(name);
            Attrs(attrs);
            _writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write HTML-encoded text.
        /// </summary>
        /// <param name="text">The text to HTML-encode</param>
        protected internal void Text(string text)
        {
            _writer.Write(text);
        }

        /// <summary>
        /// Render a string without HTML-encoding it first.
        /// </summary>
        /// <param name="rawHtml">The pre-encoded string</param>
        protected internal void Raw(string rawHtml)
        {
            _writer.WriteRaw(rawHtml);
        }

        /// <summary>
        /// Write HTML.
        /// </summary>
        /// <param name="html">The HTML to write.</param>
        [Obsolete("This method has been renamed to Html()")]
        protected void Write(Html html) => Html(html);

        /// <summary>
        /// Write HTML.
        /// </summary>
        /// <param name="html">The HTML to write.</param>
        protected void Html(Html html)
        {
            html.WriteImpl(ref _writer);
        }

        /// <summary>
        /// Override this method to write your HTML.
        /// </summary>
        protected abstract void Build();




        private void StartTag(string name)
        {
            _writer.WriteRaw('<');
            _writer.Write(name);
        }
        private void StartTagRaw(string name)
        {
            _writer.WriteRaw('<');
            _writer.WriteRaw(name);
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
            _writer.WriteRaw(' ');
            attr.Write(ref _writer);
        }
    }
}
