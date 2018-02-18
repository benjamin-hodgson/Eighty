using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Eighty
{
    /// <summary>
    /// Represents an HTML attribute.
    /// </summary>
    public readonly struct Attr
    {
        private readonly string _val;

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
            _val = WebUtility.HtmlEncode(name) + "=\"" + WebUtility.HtmlEncode(value) + "\"";
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
            _val = WebUtility.HtmlEncode(name);
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
            _val = name + "=\"" + value + "\"";
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
            _val = name;
        }

        internal void Write(TextWriter writer)
        {
            writer.Write(_val);
        }
        internal Task WriteAsync(TextWriter writer)
            => writer.WriteAsync(_val);

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
