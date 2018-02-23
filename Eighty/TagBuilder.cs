using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;

namespace Eighty
{
    /// <summary>
    /// Represents a "half-open" HTML tag which is waiting for its children.
    /// </summary>
    public readonly partial struct TagBuilder
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
        /// <returns>An instance of <see cref="Html"/></returns>
        public Html _(params Html[] children)
            => _(children.AsEnumerable());

        /// <summary>
        /// Add children to the tag.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/></returns>
        public Html _(List<Html> children)
            => _(children.AsEnumerable());

        /// <summary>
        /// Add children to the tag.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/></returns>
        public Html _(ImmutableList<Html> children)
            => _(children.AsEnumerable());

        /// <summary>
        /// Add children to the tag.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/></returns>
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
        /// <returns>An instance of <see cref="Html"/></returns>
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
    }
}
