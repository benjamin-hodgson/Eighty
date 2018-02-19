using System;
using System.IO;
using System.Net;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Eighty
{
    /// <summary>
    /// Represents an HTML attribute.
    /// </summary>
    public readonly struct Attr
    {
        private readonly string _name;
        private readonly string _value;
        private readonly bool _shouldEncode;

        /// <summary>
        /// Create an HTML attribute.
        /// </summary>
        /// <param name="name">The name of the attribute</param>
        /// <param name="value">The value</param>
        public Attr(string name, string value)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            _name = name;
            _value = value;
            _shouldEncode = true;
        }

        /// <summary>
        /// Create a Boolean HTML attribute.
        /// </summary>
        /// <param name="name">The name of the attribute</param>
        public Attr(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            _name = name;
            _value = null;
            _shouldEncode = true;
        }

        /// <summary>
        /// used for <see cref="Raw(string, string)"/>
        /// </summary>
        private Attr(string name, string value, object ignored)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            _name = name;
            _value = value;
            _shouldEncode = false;
        }

        /// <summary>
        /// used for <see cref="Raw(string)"/>
        /// </summary>
        private Attr(string name, object ignored)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            _name = name;
            _value = null;
            _shouldEncode = false;
        }

        internal void Write(TextWriter writer)
        {
            if (_shouldEncode)
            {
                HtmlEncoder.Default.Encode(writer, _name);
                if (_value != null)
                {
                    writer.Write("=\"");
                    HtmlEncoder.Default.Encode(writer, _value);
                    writer.Write('"');
                }
            }
            else
            {
                writer.Write(_name);
                if (_value != null)
                {
                    writer.Write("=\"");
                    writer.Write(_value);
                    writer.Write('"');
                }
            }
        }
        internal async Task WriteAsync(TextWriter writer)
        {
            string name;
            string value;
            if (_shouldEncode)
            {
                // there's no async overload of Encode(TextWriter, string)
                name = HtmlEncoder.Default.Encode(_name);
                value = _value != null ? HtmlEncoder.Default.Encode(_value) : null;
            }
            else
            {
                name = _name;
                value = _value;
            }
            await writer.WriteAsync(name).ConfigureAwait(false);
            if (value != null)
            {
                await writer.WriteAsync("=\"").ConfigureAwait(false);
                await writer.WriteAsync(value).ConfigureAwait(false);
                await writer.WriteAsync('"').ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Create an HTML attribute without HTML-encoding the name and value first.
        /// </summary>
        /// <param name="name">The pre-encoded name</param>
        /// <param name="value">The pre-encoded value</param>
        /// <returns>An HTML attribute</returns>
        public static Attr Raw(string name, string value)
            => new Attr(name, value, _ignored);

        /// <summary>
        /// Create a Boolean HTML attribute without HTML-encoding the name first.
        /// </summary>
        /// <param name="name">The pre-encoded name</param>
        /// <returns>An HTML attribute</returns>
        public static Attr Raw(string name)
            => new Attr(name, _ignored);

        private static readonly object _ignored = new object();

        /// <summary>
        /// Create an HTML attribute.
        /// </summary>
        /// <param name="nameValue">The name and value of the attribute</param>
        public static implicit operator Attr((string name, string value) nameValue)
            => new Attr(nameValue.name, nameValue.value);
    }
}
