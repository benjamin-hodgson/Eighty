#region GeneratedCode
using System;

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
            StartTag(name);
            Attrs(attr1);
            _writer.WriteRaw('>');
            return new TagBuilder(name, this, true);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2)
        {
            StartTag(name);
            Attrs(attr1, attr2);
            _writer.WriteRaw('>');
            return new TagBuilder(name, this, true);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag(name);
            Attrs(attr1, attr2, attr3);
            _writer.WriteRaw('>');
            return new TagBuilder(name, this, true);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag(name);
            Attrs(attr1, attr2, attr3, attr4);
            _writer.WriteRaw('>');
            return new TagBuilder(name, this, true);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag(name);
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.WriteRaw('>');
            return new TagBuilder(name, this, true);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag(name);
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.WriteRaw('>');
            return new TagBuilder(name, this, true);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag(name);
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.WriteRaw('>');
            return new TagBuilder(name, this, true);
        }

        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed after setting the tag's children.</returns>
        protected TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag(name);
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.WriteRaw('>');
            return new TagBuilder(name, this, true);
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1)
        {
            StartTag(name);
            Attrs(attr1);
            _writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2)
        {
            StartTag(name);
            Attrs(attr1, attr2);
            _writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag(name);
            Attrs(attr1, attr2, attr3);
            _writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag(name);
            Attrs(attr1, attr2, attr3, attr4);
            _writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag(name);
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag(name);
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag(name);
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        protected void SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag(name);
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.WriteRaw("/>");
        }
    }
}
#endregion
