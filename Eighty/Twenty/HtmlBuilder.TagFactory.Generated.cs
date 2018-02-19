#region GeneratedCode
using System;
using System.Text.Encodings.Web;

namespace Eighty.Twenty
{
    public abstract partial class HtmlBuilder
    {
        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1)
        {
            var safeName = HtmlEncoder.Default.Encode(name);
            StartTag(safeName);
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder(safeName, _writer);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2)
        {
            var safeName = HtmlEncoder.Default.Encode(name);
            StartTag(safeName);
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder(safeName, _writer);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3)
        {
            var safeName = HtmlEncoder.Default.Encode(name);
            StartTag(safeName);
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder(safeName, _writer);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            var safeName = HtmlEncoder.Default.Encode(name);
            StartTag(safeName);
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder(safeName, _writer);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            var safeName = HtmlEncoder.Default.Encode(name);
            StartTag(safeName);
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder(safeName, _writer);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            var safeName = HtmlEncoder.Default.Encode(name);
            StartTag(safeName);
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder(safeName, _writer);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            var safeName = HtmlEncoder.Default.Encode(name);
            StartTag(safeName);
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder(safeName, _writer);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            var safeName = HtmlEncoder.Default.Encode(name);
            StartTag(safeName);
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder(safeName, _writer);
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1)
        {
            StartTag(HtmlEncoder.Default.Encode(name));
            Attrs(attr1);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2)
        {
            StartTag(HtmlEncoder.Default.Encode(name));
            Attrs(attr1, attr2);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag(HtmlEncoder.Default.Encode(name));
            Attrs(attr1, attr2, attr3);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag(HtmlEncoder.Default.Encode(name));
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag(HtmlEncoder.Default.Encode(name));
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag(HtmlEncoder.Default.Encode(name));
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag(HtmlEncoder.Default.Encode(name));
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag(HtmlEncoder.Default.Encode(name));
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write("/>");
        }
    }
}
#endregion
