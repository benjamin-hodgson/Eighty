using System;
using System.Threading.Tasks;

namespace Eighty;

/// <summary>
/// Represents an HTML attribute.
/// </summary>
public readonly struct Attr : IEquatable<Attr>
{
    private static readonly object _ignored = new();

    private readonly string _name;
    private readonly string? _value;
    private readonly bool _shouldEncode;

    /// <summary>
    /// Create an HTML attribute.
    /// </summary>
    /// <param name="name">The name of the attribute.</param>
    /// <param name="value">The value.</param>
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
    /// <param name="name">The name of the attribute.</param>
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
    /// used for <see cref="Raw(string, string)"/>.
    /// </summary>
    private Attr(string name, string value, object _)
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
    /// used for <see cref="Raw(string)"/>.
    /// </summary>
    private Attr(string name, object _)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        _name = name;
        _value = null;
        _shouldEncode = false;
    }

    /// <inheritdoc />
    public bool Equals(Attr attr)
        => string.Equals(_name, attr._name)
        && string.Equals(_value, attr._value)
        && _shouldEncode.Equals(attr._shouldEncode);

    /// <inheritdoc />
    public override bool Equals(object? other)
        => other is Attr a && Equals(a);

    /// <inheritdoc />
    public override int GetHashCode()
    {
        // https://stackoverflow.com/a/263416/1523776
        unchecked
        {
            var hash = 17;
            hash = (hash * 23) + _name.GetHashCode();
            hash = (hash * 23) + (_value?.GetHashCode() ?? 0);
            hash = (hash * 23) + _shouldEncode.GetHashCode();
            return hash;
        }
    }

    internal void Write(ref HtmlEncodingTextWriter writer)
    {
        if (_shouldEncode)
        {
            writer.Write(_name);
            if (_value != null)
            {
                writer.WriteRaw("=\"");
                writer.Write(_value);
                writer.WriteRaw('"');
            }
        }
        else
        {
            writer.WriteRaw(_name);
            if (_value != null)
            {
                writer.WriteRaw("=\"");
                writer.WriteRaw(_value);
                writer.WriteRaw('"');
            }
        }
    }

    internal async Task WriteAsync(AsyncHtmlEncodingTextWriter writer)
    {
        if (_shouldEncode)
        {
            await writer.Write(_name).ConfigureAwait(false);
            if (_value != null)
            {
                await writer.WriteRaw("=\"").ConfigureAwait(false);
                await writer.Write(_value).ConfigureAwait(false);
                await writer.WriteRaw('"').ConfigureAwait(false);
            }
        }
        else
        {
            await writer.WriteRaw(_name).ConfigureAwait(false);
            if (_value != null)
            {
                await writer.WriteRaw("=\"").ConfigureAwait(false);
                await writer.WriteRaw(_value).ConfigureAwait(false);
                await writer.WriteRaw('"').ConfigureAwait(false);
            }
        }
    }

    /// <summary>
    /// Create an HTML attribute without HTML-encoding the name and value first.
    /// </summary>
    /// <param name="name">The pre-encoded name.</param>
    /// <param name="value">The pre-encoded value.</param>
    /// <returns>An HTML attribute.</returns>
    public static Attr Raw(string name, string value)
        => new(name, value, _ignored);

    /// <summary>
    /// Create a Boolean HTML attribute without HTML-encoding the name first.
    /// </summary>
    /// <param name="name">The pre-encoded name.</param>
    /// <returns>An HTML attribute.</returns>
    public static Attr Raw(string name)
        => new(name, _ignored);

    /// <summary>
    /// Create an HTML attribute.
    /// </summary>
    /// <param name="nameValue">The name and value of the attribute.</param>
    public static implicit operator Attr((string Name, string Value) nameValue)
        => FromValueTuple(nameValue);

    /// <summary>
    /// Create an HTML attribute.
    /// </summary>
    /// <param name="nameValue">The name and value of the attribute.</param>
    /// <returns>An <see cref="Attr" />.</returns>
    public static Attr FromValueTuple((string Name, string Value) nameValue)
        => new(nameValue.Name, nameValue.Value);
}
