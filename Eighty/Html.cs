using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;

namespace Eighty
{
    /// <summary>
    /// Represents HTML that can be written to a stream
    /// </summary>
    public abstract partial class Html
    {
        private protected Html() { }

        internal abstract void WriteImpl(TextWriter writer);
        internal abstract Task WriteAsyncImpl(TextWriter writer);

        /// <summary>
        /// Write the HTML to a <see cref="TextWriter"/>
        /// </summary>
        /// <param name="writer">The writer</param>
        public void Write(TextWriter writer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }
            WriteImpl(writer);
        }

        /// <summary>
        /// Write the HTML to a <see cref="TextWriter"/>
        /// </summary>
        /// <param name="writer">The writer</param>
        public Task WriteAsync(TextWriter writer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }
            return WriteAsyncImpl(writer);
        }

        /// <summary>
        /// Write the HTML to a <see cref="string"/>
        /// </summary>
        public override string ToString()
        {
            using (var writer = new StringWriter())
            {
                Write(writer);
                return writer.ToString();
            }
        }

        /// <summary>
        /// Create a tag which takes children.
        /// </summary>
        public static TagBuilder Tag(string name, params Attr[] attrs)
            => Tag(name, attrs.AsEnumerable());
        /// <summary>
        /// Create a tag which takes children.
        /// </summary>
        public static TagBuilder Tag(string name, IEnumerable<Attr> attrs)
        {
            if (attrs == null)
            {
                throw new ArgumentNullException(nameof(attrs));
            }
            return new TagBuilder(HtmlEncoder.Default.Encode(name), attrs.ToImmutableArray());
        }


        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, params Html[] children)
            => Tag_(name, children.AsEnumerable());

        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, List<Html> children)
            => Tag_(name, children.AsEnumerable());

        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, ImmutableList<Html> children)
            => Tag_(name, children.AsEnumerable());
        
        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, IEnumerable<Html> children)
        {
            if (children == null)
            {
                throw new ArgumentNullException(nameof(children));
            }
            return Tag_(name, children.ToImmutableArray());
        }

        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, ImmutableArray<Html> children)
        {
            foreach (var child in children)
            {
                if (child == null)
                {
                    throw new ArgumentNullException(nameof(children));
                }
            }
            return new Tag(HtmlEncoder.Default.Encode(name), ImmutableArray.Create<Attr>(), children);
        }

        
        /// <summary>
        /// Create a tag which does not take children.
        /// </summary>
        public static Html SelfClosingTag(string name, params Attr[] attrs)
            => SelfClosingTag(name, attrs.AsEnumerable());

        /// <summary>
        /// Create a tag which does not take children.
        /// </summary>
        public static Html SelfClosingTag(string name, IEnumerable<Attr> attrs)
        {
            if (attrs == null)
            {
                throw new ArgumentNullException(nameof(attrs));
            }
            return new SelfClosingTag(HtmlEncoder.Default.Encode(name), attrs.ToImmutableArray());
        }


        /// <summary>
        /// Render HTML-encoded text.
        /// </summary>
        /// <param name="text">The text to HTML-encode</param>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html Text(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            return Raw(HtmlEncoder.Default.Encode(text));
        }

        /// <summary>
        /// Render a string without HTML-encoding it first.
        /// </summary>
        /// <param name="rawHtml">The pre-encoded string</param>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html Raw(string rawHtml)
        {
            if (rawHtml == null)
            {
                throw new ArgumentNullException(nameof(rawHtml));
            }
            return new Raw(rawHtml);
        }
        
        /// <summary>
        /// Put some siblings next to each other.
        /// </summary>
        public static Html _(params Html[] siblings)
            => _(siblings.AsEnumerable());

        /// <summary>
        /// Put some siblings next to each other.
        /// </summary>
        public static Html _(List<Html> siblings)
            => _(siblings.AsEnumerable());

        /// <summary>
        /// Put some siblings next to each other.
        /// </summary>
        public static Html _(ImmutableList<Html> siblings)
            => _(siblings.AsEnumerable());

        /// <summary>
        /// Put some siblings next to each other.
        /// </summary>
        public static Html _(IEnumerable<Html> siblings)
        {
            if (siblings == null)
            {
                throw new ArgumentNullException(nameof(siblings));
            }
            return _(siblings.ToImmutableArray());
        }
            
        /// <summary>
        /// Put some siblings next to each other.
        /// </summary>
        public static Html _(ImmutableArray<Html> siblings)
        {
            foreach (var sibling in siblings)
            {
                if (sibling == null)
                {
                    throw new ArgumentNullException(nameof(siblings));
                }
            }
            return new Sequence(siblings);
        }

        /// <summary>
        /// Render HTML-encoded text.
        /// </summary>
        /// <param name="text">The text to HTML-encode</param>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static implicit operator Html(string text)
            => Text(text);
        /// <summary>
        /// Put some siblings next to each other.
        /// </summary>
        public static implicit operator Html(Html[] siblings)
            => _(siblings);
        /// <summary>
        /// Put some siblings next to each other.
        /// </summary>
        public static implicit operator Html(List<Html> siblings)
            => _(siblings);
        /// <summary>
        /// Put some siblings next to each other.
        /// </summary>
        public static implicit operator Html(ImmutableList<Html> siblings)
            => _(siblings);
        /// <summary>
        /// Put some siblings next to each other.
        /// </summary>
        public static implicit operator Html(ImmutableArray<Html> siblings)
            => _(siblings);
        /// <summary>
        /// Create a tag with no children.
        /// </summary>
        public static implicit operator Html(TagBuilder tagBuilder)
            => tagBuilder._();
    }
}
