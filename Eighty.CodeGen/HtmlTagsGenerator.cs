using System.Linq;

namespace Eighty.CodeGen
{
    class HtmlTagsGenerator : EightyCodeGenerator
    {
        public string GenerateTags()
        {
            var methods = string.Concat(_elements.Select(
                el => el.isSelfClosing
                    ? SelfClosingTagDef(el.name, el.attrs)
                    : TagDef(el.name, el.attrs)
            ));

            return $@"#region GeneratedCode
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Eighty
{{
    public abstract partial class Html
    {{{methods}    }}
}}
#endregion
";
        }


        private string TagDef(string name, string[] attrs)
            => $@"
        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element.
        /// </summary>
        /// <returns>A <see cref=""TagBuilder""/> waiting for the element's children</returns>
        public static TagBuilder {CsId(name)}({Params(attrs)}
        )
        {{
            var attrCount = 0;
            {CountNonNulls(attrs)}

            var builder = _attrBuilder.Value;
            builder.Capacity = attrCount;
            {PackBuilder(attrs)}

            return new TagBuilder(""{name}"", builder.MoveToImmutable());
        }}

        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element.
        /// </summary>
        /// <returns>A <see cref=""TagBuilder""/> waiting for the element's children</returns>
        public static TagBuilder {CsId(name)}(params Attr[] attrs)
        {{
            return {CsId(name)}(attrs.AsEnumerable());
        }}

        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element.
        /// </summary>
        /// <returns>A <see cref=""TagBuilder""/> waiting for the element's children</returns>
        public static TagBuilder {CsId(name)}(IEnumerable<Attr> attrs)
        {{
            if (attrs == null)
            {{
                throw new ArgumentNullException(nameof(attrs));
            }}
            return new TagBuilder(""{name}"", attrs.ToImmutableArray());
        }}
        {TagAttrs(name)}

        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element without any attributes.
        /// </summary>
        /// <returns>The element</returns>
        public static Html {CsId(name)}_(params Html[] children)
        {{
            return {CsId(name)}_(children.AsEnumerable());
        }}

        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element without any attributes.
        /// </summary>
        /// <returns>The element</returns>
        public static Html {CsId(name)}_(List<Html> children)
        {{
            return {CsId(name)}_(children.AsEnumerable());
        }}

        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element without any attributes.
        /// </summary>
        /// <returns>The element</returns>
        public static Html {CsId(name)}_(ImmutableList<Html> children)
        {{
            return {CsId(name)}_(children.AsEnumerable());
        }}

        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element without any attributes.
        /// </summary>
        /// <returns>The element</returns>
        public static Html {CsId(name)}_(IEnumerable<Html> children)
        {{
            if (children == null)
            {{
                throw new ArgumentNullException(nameof(children));
            }}
            return {CsId(name)}_(children.ToImmutableArray());
        }}

        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element without any attributes.
        /// </summary>
        /// <returns>The element</returns>
        public static Html {CsId(name)}_(ImmutableArray<Html> children)
        {{
            foreach (var child in children)
            {{
                if (child == null)
                {{
                    throw new ArgumentNullException(nameof(children));
                }}
            }}
            return new Tag(""{name}"", ImmutableArray.Create<Attr>(), children);
        }}
        {TagChildren(name)}
";

        private string SelfClosingTagDef(string name, string[] attrs)
            => $@"
        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element.
        /// </summary>
        /// <returns>The element</returns>
        public static Html {CsId(name)}({Params(attrs)}
        )
        {{
            var attrCount = 0;
            {CountNonNulls(attrs)}

            var builder = _attrBuilder.Value;
            builder.Capacity = attrCount;
            {PackBuilder(attrs)}

            return new SelfClosingTag(""{name}"", builder.MoveToImmutable());
        }}

        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element.
        /// </summary>
        /// <returns>The element</returns>
        public static Html {CsId(name)}(params Attr[] attrs)
            => {CsId(name)}(attrs.AsEnumerable());

        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element.
        /// </summary>
        /// <returns>The element</returns>
        public static Html {CsId(name)}(IEnumerable<Attr> attrs)
        {{
            if (attrs == null)
            {{
                throw new ArgumentNullException(nameof(attrs));
            }}
            return new SelfClosingTag(""{name}"", attrs.ToImmutableArray());
        }}
        {SelfClosingTagAttrs(name)}
";

        private string TagAttrs(string name)
            => string.Join("\n", Enumerable.Range(1, 8).Select(n => $@"
        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element.
        /// </summary>
        /// <returns>A <see cref=""TagBuilder""/> waiting for the element's children</returns>
        public static TagBuilder {CsId(name)}({AttrParams(n)})
        {{
            return new TagBuilder(""{name}"", ImmutableArrayFactory.Create({AttrArgs(n)}));
        }}"));

        private string SelfClosingTagAttrs(string name)
            => string.Join("\n", Enumerable.Range(1, 8).Select(n => $@"
        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element.
        /// </summary>
        /// <returns>The element</returns>
        public static Html {CsId(name)}({AttrParams(n)})
        {{
            return new SelfClosingTag(""{name}"", ImmutableArrayFactory.Create({AttrArgs(n)}));
        }}"));

        private string TagChildren(string name)
            => string.Join("\n", Enumerable.Range(1, 8).Select(n => $@"
        /// <summary>
        /// Build {IndefiniteArticle(name)} {name} element without any attributes.
        /// </summary>
        /// <returns>The element</returns>
        public static Html {CsId(name)}_({ChildParams(n)})
        {{
            {CheckChildNulls(n)}
            return new Tag(""{name}"", ImmutableArray.Create<Attr>(), ImmutableArrayFactory.Create({ChildArgs(n)}));
        }}"));


        private string CountNonNulls(string[] attrs)
            => string.Concat(attrs.Select(a => 
                a[0] == '!'
                    ? $@"
            if ({CsId(a)})
            {{
                attrCount++;
            }}"
                    : $@"
            if ({CsId(a)} != null)
            {{
                attrCount++;
            }}"));

        private string PackBuilder(string[] attrs)
            => string.Concat(attrs.Select(a =>
                a[0] == '!'
                    ? $@"
            if ({CsId(a)})
            {{
                builder.Add(new Attr(""{a.Substring(1)}""));
            }}"
                    : $@"
            if ({CsId(a)} != null)
            {{
                builder.Add(new Attr(""{a}"", {CsId(a)}));
            }}"));
    }
}
