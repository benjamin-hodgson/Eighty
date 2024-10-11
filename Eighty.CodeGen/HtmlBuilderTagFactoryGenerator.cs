using System.Linq;

using static Eighty.CodeGen.CodeGenHelpers;

namespace Eighty.CodeGen;

internal static class HtmlBuilderTagFactoryGenerator
{
    public static string GenerateTagFactoryMethods()
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

    private static string TagMethod(int number)
        => $@"
        /// <summary>
        /// Write a tag which takes children.
        /// </summary>
        /// <returns>A <see cref=""IDisposable""/> which MUST be disposed after setting the tag's children.</returns>
        [NoDoc]
        protected IDisposable Tag(string name, {AttrParams(number)})
        {{
            StartTag(name);
            Attrs({AttrArgs(number)});
            _writer.Get().WriteRaw('>');
            return new TagBuilder(name, this, true);
        }}
";

    private static string SelfClosingTagMethod(int number)
        => $@"
        /// <summary>
        /// Write a tag which does not take children.
        /// </summary>
        [NoDoc]
        protected void SelfClosingTag(string name, {AttrParams(number)})
        {{
            StartTag(name);
            Attrs({AttrArgs(number)});
            _writer.Get().WriteRaw(""/>"");
        }}
";
}
