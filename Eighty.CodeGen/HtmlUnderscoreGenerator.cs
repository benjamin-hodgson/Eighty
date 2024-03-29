﻿using System.Linq;

namespace Eighty.CodeGen;

internal static class HtmlUnderscoreGenerator
{
    public static string GenerateUnderscores()
    {
        var methods = string.Concat(Enumerable.Range(1, 8).Select(UnderscoreMethod));

        return $@"#region GeneratedCode
using System;
using System.Threading;
using System.Collections.Immutable;

namespace Eighty
{{
    public abstract partial class Html
    {{{methods}    }}
}}
#endregion
";
    }

    private static string UnderscoreMethod(int number)
        => $@"
        /// <summary>
        /// Put some siblings next to each other.
        /// </summary>
        [NoDoc]
        public static Html _({SiblingParams(number)})
        {{
            return _(ImmutableArrayFactory.Create({SiblingArgs(number)}));
        }}
";

    private static string SiblingParams(int number)
        => string.Join(", ", Enumerable.Range(1, number).Select(n => "Html sibling" + n));

    private static string SiblingArgs(int number)
        => string.Join(", ", Enumerable.Range(1, number).Select(n => "sibling" + n));
}
