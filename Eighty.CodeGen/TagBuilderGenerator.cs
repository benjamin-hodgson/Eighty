using System.Linq;

namespace Eighty.CodeGen
{
    class TagBuilderGenerator : EightyCodeGenerator
    {
        public string GenerateTagBuilderMethods()
        {
            var underscoreMethods = string.Concat(Enumerable.Range(1, 8).Select(UnderscoreMethod));

            return $@"#region GeneratedCode
using System;
using System.Threading;
using System.Collections.Immutable;

namespace Eighty
{{
    public readonly partial struct TagBuilder
    {{{underscoreMethods}    }}
}}
#endregion
";
        }


        private string UnderscoreMethod(int number)
            => $@"
        /// <summary>
        /// Add children to the tag.
        /// </summary>
        /// <returns>An instance of <see cref=""Html""/></returns>
        public Html _({ChildParams(number)})
        {{{CheckChildNulls(number)}
            return new Tag(_name, _attrs, ImmutableArrayFactory.Create({ChildArgs(number)}), _shouldEncodeName);
        }}
";
    }
}
