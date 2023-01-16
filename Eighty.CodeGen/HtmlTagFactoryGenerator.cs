﻿using System.Linq;

using static Eighty.CodeGen.CodeGenHelpers;

namespace Eighty.CodeGen;

internal static class HtmlTagFactoryGenerator
{
    public static string GenerateTagFactoryMethods()
    {
        var tagMethods = string.Concat(Enumerable.Range(1, 8).Select(TagMethod));
        var tagUnderscoreMethods = string.Concat(Enumerable.Range(1, 8).Select(TagUnderscoreMethod));
        var selfClosingTagMethods = string.Concat(Enumerable.Range(1, 8).Select(SelfClosingTagMethod));

        return $@"#region GeneratedCode
using System;
using System.Collections.Immutable;

namespace Eighty
{{
    public abstract partial class Html
    {{{tagMethods}{tagUnderscoreMethods}{selfClosingTagMethods}    }}
}}
#endregion
";
    }

    private static string TagMethod(int number)
        => $@"
        /// <summary>
        /// Create a tag which takes children.
        /// </summary>
        [NoDoc]
        public static TagBuilder Tag(string name, {AttrParams(number)})
        {{
            return new TagBuilder(name, ImmutableArrayFactory.Create({AttrArgs(number)}), true);
        }}
";

    private static string TagUnderscoreMethod(int number)
        => $@"
        /// <summary>
        /// Create a tag without any attributes.
        /// </summary>
        [NoDoc]
        public static Html Tag_(string name, {ChildParams(number)})
        {{{CheckChildNulls(number)}
            return new Tag(name, ImmutableArray.Create<Attr>(), ImmutableArrayFactory.Create({ChildArgs(number)}), true);
        }}
";

    private static string SelfClosingTagMethod(int number)
        => $@"
        /// <summary>
        /// Create a tag which does not take children.
        /// </summary>
        [NoDoc]
        public static Html SelfClosingTag(string name, {AttrParams(number)})
        {{
            return new SelfClosingTag(name, ImmutableArrayFactory.Create({AttrArgs(number)}), true);
        }}
";
}
