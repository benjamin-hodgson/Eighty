using System;
using System.Buffers;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Eighty.Twenty;

namespace Eighty
{
    /// <summary>
    /// Represents HTML that can be written to a stream
    /// </summary>
    public abstract partial class Html
    {
        /// <summary>
        /// Can this <see cref="Html"/> write itself asynchronously?
        /// 
        /// Returns false if the HTML contains any calls to <see cref="Builder(Func{HtmlBuilder})"/>.
        /// 
        /// If this returns false, <see cref="WriteAsync(TextWriter)"/> will throw <see cref="InvalidOperationException"/>
        /// </summary>
        /// <returns>A <see cref="System.Boolean"/> indicating whether this <see cref="Html"/> can write itself asynchronously</returns>
        public bool CanWriteAsync { get; }

        private protected Html(bool canWriteAsync)
        {
            CanWriteAsync = canWriteAsync;
        }

        internal abstract void WriteImpl(ref HtmlEncodingTextWriter writer);
        internal abstract Task WriteAsyncImpl(AsyncHtmlEncodingTextWriter writer);

        /// <summary>
        /// Write the HTML to a <see cref="TextWriter"/>
        /// </summary>
        /// <param name="writer">The writer</param>
        public void Write(TextWriter writer)
        {
            Write(writer, HtmlEncoder.Default);
        }

        /// <summary>
        /// Write the HTML to a <see cref="TextWriter"/>, using an <see cref="HtmlEncoder"/> to encode input text
        /// </summary>
        /// <param name="writer">The writer</param>
        /// <param name="htmlEncoder">The HTML encoder</param>
        public unsafe void Write(TextWriter writer, HtmlEncoder htmlEncoder)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }
            if (htmlEncoder == null)
            {
                throw new ArgumentNullException(nameof(htmlEncoder));
            }

            var buffer = ArrayPool<char>.Shared.Rent(4096);
            fixed (char* start = buffer)
            {
                var htmlEncodingTextWriter = new HtmlEncodingTextWriter(writer, htmlEncoder, buffer, start, buffer.Length);
                WriteImpl(ref htmlEncodingTextWriter);
                htmlEncodingTextWriter.Flush();
            }
            ArrayPool<char>.Shared.Return(buffer);
        }

        /// <summary>
        /// Write the HTML to a <see cref="TextWriter"/>
        /// </summary>
        /// <param name="writer">The writer</param>
        public Task WriteAsync(TextWriter writer)
            => WriteAsync(writer, HtmlEncoder.Default);

        /// <summary>
        /// Write the HTML to a <see cref="TextWriter"/>, using an <see cref="HtmlEncoder"/> to encode input text
        /// </summary>
        /// <param name="writer">The writer</param>
        /// <param name="htmlEncoder">The HTML encoder</param>
        /// <exception cref="InvalidOperationException">Thrown if <see cref="CanWriteAsync"/> is false (ie if this <see cref="Html"/> contains an <see cref="HtmlBuilder"/>.</exception>
        public async Task WriteAsync(TextWriter writer, HtmlEncoder htmlEncoder)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }
            if (htmlEncoder == null)
            {
                throw new ArgumentNullException(nameof(htmlEncoder));
            }
            if (!CanWriteAsync)
            {
                throw new InvalidOperationException("Can't write this HTML asynchronously because it contains an HtmlBuilder");
            }

            var htmlEncodingTextWriter = new AsyncHtmlEncodingTextWriter(writer, htmlEncoder);
            await WriteAsyncImpl(htmlEncodingTextWriter).ConfigureAwait(false);
            await htmlEncodingTextWriter.FlushAndClear().ConfigureAwait(false);
        }

        /// <summary>
        /// Write the HTML to a <see cref="string"/>
        /// </summary>
        public override string ToString()
        {
            using (var writer = new PooledStringWriter())
            {
                Write(writer);
                return writer.ToString();
            }
        }
        
        /// <summary>
        /// An empty chunk of <see cref="Html"/>
        /// </summary>
        public static Html Empty { get; } = _();

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
            return new TagBuilder(name, attrs.ToImmutableArray(), true);
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
            return new Tag(name, ImmutableArray.Create<Attr>(), children, true);
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
            return new SelfClosingTag(name, attrs.ToImmutableArray(), true);
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
            return new Text(text);
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
        /// Run the <see cref="HtmlBuilder"/> returned by <paramref name="builderFactory"/>.
        /// 
        /// The <see cref="Html"/> returned from this method cannot write itself asynchronously;
        /// its <see cref="CanWriteAsync"/> will return false and its <see cref="WriteAsync(TextWriter)"/> method will throw <see cref="InvalidOperationException"/>.
        /// 
        /// <paramref name="builderFactory"/> should generally return a newly created <see cref="HtmlBuilder"/>,
        /// not a cached instance. Returning a cached <see cref="HtmlBuilder"/> is risky if it's possible that this
        /// <see cref="Html"/>'s <see cref="Write(TextWriter)"/> method will be called concurrently by multiple threads.
        /// </summary>
        /// <param name="builderFactory">A function to create an <see cref="HtmlBuilder"/></param>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html Builder(Func<HtmlBuilder> builderFactory)
        {
            if (builderFactory == null)
            {
                throw new ArgumentNullException(nameof(builderFactory));
            }
            return new Builder(builderFactory);
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
