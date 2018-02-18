#region GeneratedCode
using System;
using System.Collections.Immutable;

namespace Eighty
{
    public abstract partial class Html
    {
        /// <summary>
        /// Create a tag which takes children.
        /// </summary>
        public static TagBuilder Tag(string name, Attr attr1)
        {
            return new TagBuilder(name, ImmutableArrayFactory.Create(attr1));
        }

        /// <summary>
        /// Create a tag which takes children.
        /// </summary>
        public static TagBuilder Tag(string name, Attr attr1, Attr attr2)
        {
            return new TagBuilder(name, ImmutableArrayFactory.Create(attr1, attr2));
        }

        /// <summary>
        /// Create a tag which takes children.
        /// </summary>
        public static TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3)
        {
            return new TagBuilder(name, ImmutableArrayFactory.Create(attr1, attr2, attr3));
        }

        /// <summary>
        /// Create a tag which takes children.
        /// </summary>
        public static TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            return new TagBuilder(name, ImmutableArrayFactory.Create(attr1, attr2, attr3, attr4));
        }

        /// <summary>
        /// Create a tag which takes children.
        /// </summary>
        public static TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            return new TagBuilder(name, ImmutableArrayFactory.Create(attr1, attr2, attr3, attr4, attr5));
        }

        /// <summary>
        /// Create a tag which takes children.
        /// </summary>
        public static TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            return new TagBuilder(name, ImmutableArrayFactory.Create(attr1, attr2, attr3, attr4, attr5, attr6));
        }

        /// <summary>
        /// Create a tag which takes children.
        /// </summary>
        public static TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            return new TagBuilder(name, ImmutableArrayFactory.Create(attr1, attr2, attr3, attr4, attr5, attr6, attr7));
        }

        /// <summary>
        /// Create a tag which takes children.
        /// </summary>
        public static TagBuilder Tag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            return new TagBuilder(name, ImmutableArrayFactory.Create(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8));
        }

        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, Html child1)
        {
            if (child1 == null)
            {
                throw new ArgumentNullException(nameof(child1));
            }
            return new Tag(name, ImmutableArray.Create<Attr>(), ImmutableArrayFactory.Create(child1));
        }

        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, Html child1, Html child2)
        {
            if (child1 == null)
            {
                throw new ArgumentNullException(nameof(child1));
            }
            if (child2 == null)
            {
                throw new ArgumentNullException(nameof(child2));
            }
            return new Tag(name, ImmutableArray.Create<Attr>(), ImmutableArrayFactory.Create(child1, child2));
        }

        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, Html child1, Html child2, Html child3)
        {
            if (child1 == null)
            {
                throw new ArgumentNullException(nameof(child1));
            }
            if (child2 == null)
            {
                throw new ArgumentNullException(nameof(child2));
            }
            if (child3 == null)
            {
                throw new ArgumentNullException(nameof(child3));
            }
            return new Tag(name, ImmutableArray.Create<Attr>(), ImmutableArrayFactory.Create(child1, child2, child3));
        }

        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, Html child1, Html child2, Html child3, Html child4)
        {
            if (child1 == null)
            {
                throw new ArgumentNullException(nameof(child1));
            }
            if (child2 == null)
            {
                throw new ArgumentNullException(nameof(child2));
            }
            if (child3 == null)
            {
                throw new ArgumentNullException(nameof(child3));
            }
            if (child4 == null)
            {
                throw new ArgumentNullException(nameof(child4));
            }
            return new Tag(name, ImmutableArray.Create<Attr>(), ImmutableArrayFactory.Create(child1, child2, child3, child4));
        }

        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, Html child1, Html child2, Html child3, Html child4, Html child5)
        {
            if (child1 == null)
            {
                throw new ArgumentNullException(nameof(child1));
            }
            if (child2 == null)
            {
                throw new ArgumentNullException(nameof(child2));
            }
            if (child3 == null)
            {
                throw new ArgumentNullException(nameof(child3));
            }
            if (child4 == null)
            {
                throw new ArgumentNullException(nameof(child4));
            }
            if (child5 == null)
            {
                throw new ArgumentNullException(nameof(child5));
            }
            return new Tag(name, ImmutableArray.Create<Attr>(), ImmutableArrayFactory.Create(child1, child2, child3, child4, child5));
        }

        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, Html child1, Html child2, Html child3, Html child4, Html child5, Html child6)
        {
            if (child1 == null)
            {
                throw new ArgumentNullException(nameof(child1));
            }
            if (child2 == null)
            {
                throw new ArgumentNullException(nameof(child2));
            }
            if (child3 == null)
            {
                throw new ArgumentNullException(nameof(child3));
            }
            if (child4 == null)
            {
                throw new ArgumentNullException(nameof(child4));
            }
            if (child5 == null)
            {
                throw new ArgumentNullException(nameof(child5));
            }
            if (child6 == null)
            {
                throw new ArgumentNullException(nameof(child6));
            }
            return new Tag(name, ImmutableArray.Create<Attr>(), ImmutableArrayFactory.Create(child1, child2, child3, child4, child5, child6));
        }

        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, Html child1, Html child2, Html child3, Html child4, Html child5, Html child6, Html child7)
        {
            if (child1 == null)
            {
                throw new ArgumentNullException(nameof(child1));
            }
            if (child2 == null)
            {
                throw new ArgumentNullException(nameof(child2));
            }
            if (child3 == null)
            {
                throw new ArgumentNullException(nameof(child3));
            }
            if (child4 == null)
            {
                throw new ArgumentNullException(nameof(child4));
            }
            if (child5 == null)
            {
                throw new ArgumentNullException(nameof(child5));
            }
            if (child6 == null)
            {
                throw new ArgumentNullException(nameof(child6));
            }
            if (child7 == null)
            {
                throw new ArgumentNullException(nameof(child7));
            }
            return new Tag(name, ImmutableArray.Create<Attr>(), ImmutableArrayFactory.Create(child1, child2, child3, child4, child5, child6, child7));
        }

        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, Html child1, Html child2, Html child3, Html child4, Html child5, Html child6, Html child7, Html child8)
        {
            if (child1 == null)
            {
                throw new ArgumentNullException(nameof(child1));
            }
            if (child2 == null)
            {
                throw new ArgumentNullException(nameof(child2));
            }
            if (child3 == null)
            {
                throw new ArgumentNullException(nameof(child3));
            }
            if (child4 == null)
            {
                throw new ArgumentNullException(nameof(child4));
            }
            if (child5 == null)
            {
                throw new ArgumentNullException(nameof(child5));
            }
            if (child6 == null)
            {
                throw new ArgumentNullException(nameof(child6));
            }
            if (child7 == null)
            {
                throw new ArgumentNullException(nameof(child7));
            }
            if (child8 == null)
            {
                throw new ArgumentNullException(nameof(child8));
            }
            return new Tag(name, ImmutableArray.Create<Attr>(), ImmutableArrayFactory.Create(child1, child2, child3, child4, child5, child6, child7, child8));
        }

        /// <summary>
        /// Create a tag which does not take children.
        /// </summary>
        public static Html SelfClosingTag(string name, Attr attr1)
        {
            return new SelfClosingTag(name, ImmutableArrayFactory.Create(attr1));
        }

        /// <summary>
        /// Create a tag which does not take children.
        /// </summary>
        public static Html SelfClosingTag(string name, Attr attr1, Attr attr2)
        {
            return new SelfClosingTag(name, ImmutableArrayFactory.Create(attr1, attr2));
        }

        /// <summary>
        /// Create a tag which does not take children.
        /// </summary>
        public static Html SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3)
        {
            return new SelfClosingTag(name, ImmutableArrayFactory.Create(attr1, attr2, attr3));
        }

        /// <summary>
        /// Create a tag which does not take children.
        /// </summary>
        public static Html SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            return new SelfClosingTag(name, ImmutableArrayFactory.Create(attr1, attr2, attr3, attr4));
        }

        /// <summary>
        /// Create a tag which does not take children.
        /// </summary>
        public static Html SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            return new SelfClosingTag(name, ImmutableArrayFactory.Create(attr1, attr2, attr3, attr4, attr5));
        }

        /// <summary>
        /// Create a tag which does not take children.
        /// </summary>
        public static Html SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            return new SelfClosingTag(name, ImmutableArrayFactory.Create(attr1, attr2, attr3, attr4, attr5, attr6));
        }

        /// <summary>
        /// Create a tag which does not take children.
        /// </summary>
        public static Html SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            return new SelfClosingTag(name, ImmutableArrayFactory.Create(attr1, attr2, attr3, attr4, attr5, attr6, attr7));
        }

        /// <summary>
        /// Create a tag which does not take children.
        /// </summary>
        public static Html SelfClosingTag(string name, Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            return new SelfClosingTag(name, ImmutableArrayFactory.Create(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8));
        }
    }
}
#endregion
