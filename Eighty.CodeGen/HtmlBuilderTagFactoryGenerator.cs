using System.Linq;

namespace Eighty.CodeGen
{
    class HtmlBuilderTagFactoryGenerator : EightyCodeGenerator
    {
        public string GenerateTagFactoryMethods()
        {
            var tagMethods = string.Concat(Enumerable.Range(1, 8).Select(TagMethod));
            var selfClosingTagMethods = string.Concat(Enumerable.Range(1, 8).Select(SelfClosingTagMethod));

            return $@"#region GeneratedCode
using System;

namespace Eighty.Twenty
{{
    public abstract partial class HtmlBuilder
    {{{tagMethods}{selfClosingTagMethods}    }}
}}
#endregion
";
        }


        private string TagMethod(int number)
            => $@"
        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref=""TagBuilder""/> which MUST be disposed after setting the tag's children.</returns>
        [NoDoc]
        protected TagBuilder Tag(string name, {AttrParams(number)})
        {{
            StartTag(name);
            Attrs({AttrArgs(number)});
            Writer.WriteRaw('>');
            return new TagBuilder(name, this, true);
        }}
";
        private string SelfClosingTagMethod(int number)
            => $@"
        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        [NoDoc]
        protected void SelfClosingTag(string name, {AttrParams(number)})
        {{
            StartTag(name);
            Attrs({AttrArgs(number)});
            Writer.WriteRaw(""/>"");
        }}
";
    }
}
