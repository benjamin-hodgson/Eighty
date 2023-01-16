using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Eighty;

/// <summary>
/// Represents a "half-open" HTML tag which is waiting for its children.
/// </summary>
public readonly partial struct TagBuilder : IEquatable<TagBuilder>
{
    private readonly string _name;
    private readonly ImmutableArray<Attr> _attrs;
    private readonly bool _shouldEncodeName;

    internal TagBuilder(string name, ImmutableArray<Attr> attributes, bool shouldEncodeName)
    {
        _name = name;
        _attrs = attributes;
        _shouldEncodeName = shouldEncodeName;
    }

    /// <summary>
    /// Add children to the tag.
    /// </summary>
    /// <param name="children">The child elements.</param>
    /// <returns>An instance of <see cref="Html"/>.</returns>
    [SuppressMessage("naming", "SA1300", Justification = "Purposeful")] // Element should begin with an uppercase letter
    public Html _(params Html[] children)
        => _(children.AsEnumerable());

    /// <summary>
    /// Add children to the tag.
    /// </summary>
    /// <param name="children">The child elements.</param>
    /// <returns>An instance of <see cref="Html"/>.</returns>
    [SuppressMessage("design", "CA1002", Justification = "this would be a breaking change")] // "Change List to use 'Collection<T>', 'ReadOnlyCollection<T>' or 'KeyedCollection<K,V>'"
    [SuppressMessage("naming", "SA1300", Justification = "Purposeful")] // Element should begin with an uppercase letter
    public Html _(List<Html> children)
        => _(children.AsEnumerable());

    /// <summary>
    /// Add children to the tag.
    /// </summary>
    /// <param name="children">The child elements.</param>
    /// <returns>An instance of <see cref="Html"/>.</returns>
    [SuppressMessage("naming", "SA1300", Justification = "Purposeful")] // Element should begin with an uppercase letter
    public Html _(ImmutableList<Html> children)
        => _(children.AsEnumerable());

    /// <summary>
    /// Add children to the tag.
    /// </summary>
    /// <param name="children">The child elements.</param>
    /// <returns>An instance of <see cref="Html"/>.</returns>
    [SuppressMessage("naming", "SA1300", Justification = "Purposeful")] // Element should begin with an uppercase letter
    public Html _(IEnumerable<Html> children)
    {
        if (children == null)
        {
            throw new ArgumentNullException(nameof(children));
        }

        return _(children.ToImmutableArray());
    }

    /// <summary>
    /// Add children to the tag.
    /// </summary>
    /// <param name="children">The child elements.</param>
    /// <returns>An instance of <see cref="Html"/>.</returns>
    [SuppressMessage("naming", "SA1300", Justification = "Purposeful")] // Element should begin with an uppercase letter
    public Html _(ImmutableArray<Html> children)
    {
        foreach (var child in children)
        {
            if (child == null)
            {
                throw new ArgumentNullException(nameof(children));
            }
        }

        return new Tag(_name, _attrs, children, _shouldEncodeName);
    }

    /// <inheritdoc />
    public bool Equals(TagBuilder tagBuilder)
        => string.Equals(_name, tagBuilder._name)
        && _attrs.SequenceEqual(tagBuilder._attrs)
        && _shouldEncodeName.Equals(tagBuilder._shouldEncodeName);

    /// <inheritdoc />
    public override bool Equals(object? other)
        => other is TagBuilder t && Equals(t);

    /// <inheritdoc />
    public override int GetHashCode()
    {
        // https://stackoverflow.com/a/263416/1523776
        unchecked
        {
            var hash = 17;
            hash = (hash * 23) + _name.GetHashCode();

            foreach (var attr in _attrs)
            {
                hash = (hash * 23) + attr.GetHashCode();
            }

            hash = (hash * 23) + _shouldEncodeName.GetHashCode();
            return hash;
        }
    }
}
