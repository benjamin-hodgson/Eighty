using System.Linq;

namespace Eighty.CodeGen
{
    class HtmlBuilderTagsGenerator : EightyCodeGenerator
    {
        public string GenerateFile()
        {
            var methods = string.Concat(_elements.Select(
                el => el.isSelfClosing
                    ? SelfClosingTagDef(el.name, el.attrs)
                    : TagDef(el.name, el.attrs)
            ));
            return $@"#region GeneratedCode
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Eighty.Twenty
{{
    public abstract partial class HtmlBuilder
    {{{methods}    }}
}}
#endregion
";
        }


        private string TagDef(string name, string[] attrs)
            => $@"
        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref=""TagBuilder""/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder {CsId(name)}({Params(attrs)}
        )
        {{
            StartTag(""{name}"");
            {WriteAttrs(attrs)}
            _writer.Write('>');
            return new TagBuilder(""{name}"", _writer);
        }}

        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref=""TagBuilder""/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder {CsId(name)}(params Attr[] attrs)
        {{
            StartTag(""{name}"");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder(""{name}"", _writer);
        }}

        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref=""TagBuilder""/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder {CsId(name)}(IEnumerable<Attr> attrs)
        {{
            StartTag(""{name}"");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder(""{name}"", _writer);
        }}
        {TagAttrs(name)}
";
        private string SelfClosingTagDef(string name, string[] attrs)
            => $@"
        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element.
        /// </summary>
        protected void {CsId(name)}({Params(attrs)}
        )
        {{
            StartTag(""{name}"");
            {WriteAttrs(attrs)}
            _writer.Write(""/>"");
        }}
        
        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element.
        /// </summary>
        protected void {CsId(name)}(params Attr[] attrs)
        {{
            StartTag(""{name}"");
            Attrs(attrs);
            _writer.Write(""/>"");
        }}
        
        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element.
        /// </summary>
        protected void {CsId(name)}(IEnumerable<Attr> attrs)
        {{
            StartTag(""{name}"");
            Attrs(attrs);
            _writer.Write(""/>"");
        }}
        {SelfClosingTagAttrs(name)}
";

        private string WriteAttrs(string[] attrs)
            => string.Concat(attrs.Select(a => 
                a[0] == '!'
                    ? $@"
            if ({CsId(a)})
            {{
                Attr(new Eighty.Attr(""{a.Substring(1)}""));
            }}"
                    : $@"
            if ({CsId(a)} != null)
            {{
                Attr(new Eighty.Attr(""{a}"", {CsId(a)}));
            }}"));

        private string TagAttrs(string name)
            => string.Join("\n", Enumerable.Range(1, 8).Select(n => $@"
        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref=""TagBuilder""/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder {CsId(name)}({AttrParams(n)})
        {{
            StartTag(""{name}"");
            Attrs({AttrArgs(n)});
            _writer.Write('>');
            return new TagBuilder(""{name}"", _writer);
        }}"));

        private string SelfClosingTagAttrs(string name)
            => string.Join("\n", Enumerable.Range(1, 8).Select(n => $@"
        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element.
        /// </summary>
        protected void {CsId(name)}({AttrParams(n)})
        {{
            StartTag(""{name}"");
            Attrs({AttrArgs(n)});
            _writer.Write(""/>"");
        }}"));
    }
}
