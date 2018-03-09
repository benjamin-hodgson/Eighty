using System.Linq;

namespace Eighty.CodeGen
{
    class HtmlUnderscoreGenerator : EightyCodeGenerator
    {
        public string GenerateUnderscores()
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


        private string UnderscoreMethod(int number)
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

        private string SiblingParams(int number)
            => string.Join(", ", Enumerable.Range(1, number).Select(n => "Html sibling" + n));

        private string SiblingArgs(int number)
            => string.Join(", ", Enumerable.Range(1, number).Select(n => "sibling" + n));
    }
}
