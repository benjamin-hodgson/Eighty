using System.Linq;

namespace Eighty.CodeGen
{
    class HtmlTagFactoryGenerator : EightyCodeGenerator
    {
        public string GenerateTagFactoryMethods()
        {
            var tagMethods = string.Concat(Enumerable.Range(1, 8).Select(TagMethod));
            var tagUnderscoreMethods = string.Concat(Enumerable.Range(1, 8).Select(TagUnderscoreMethod));
            var selfClosingTagMethods = string.Concat(Enumerable.Range(1, 8).Select(SelfClosingTagMethod));

            return $@"#region GeneratedCode
using System;
using System.Collections.Immutable;
using System.Text.Encodings.Web;

namespace Eighty
{{
    public abstract partial class Html
    {{{tagMethods}{tagUnderscoreMethods}{selfClosingTagMethods}    }}
}}
#endregion
";
        }


        private string TagMethod(int number)
            => $@"
        /// <summary>
        /// Create a tag which takes children.
        /// </summary>
        public static TagBuilder Tag(string name, {AttrParams(number)})
        {{
            return new TagBuilder(HtmlEncoder.Default.Encode(name), ImmutableArrayFactory.Create({AttrArgs(number)}));
        }}
";
        private string TagUnderscoreMethod(int number)
            => $@"
        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        public static Html Tag_(string name, {ChildParams(number)})
        {{{CheckChildNulls(number)}
            return new Tag(HtmlEncoder.Default.Encode(name), ImmutableArray.Create<Attr>(), ImmutableArrayFactory.Create({ChildArgs(number)}));
        }}
";
        private string SelfClosingTagMethod(int number)
            => $@"
        /// <summary>
        /// Create a tag which does not take children.
        /// </summary>
        public static Html SelfClosingTag(string name, {AttrParams(number)})
        {{
            return new SelfClosingTag(HtmlEncoder.Default.Encode(name), ImmutableArrayFactory.Create({AttrArgs(number)}));
        }}
";
    }
}
