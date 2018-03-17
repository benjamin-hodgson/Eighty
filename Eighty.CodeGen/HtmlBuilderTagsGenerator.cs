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
            StartTagRaw(""{name}"");
            {WriteAttrs(attrs)}
            _writer.Get().WriteRaw('>');
            return new TagBuilder(""{name}"", this, false);
        }}

        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref=""TagBuilder""/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder {CsId(name)}(params Attr[] attrs)
        {{
            StartTagRaw(""{name}"");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder(""{name}"", this, false);
        }}

        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref=""TagBuilder""/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder {CsId(name)}(IEnumerable<Attr> attrs)
        {{
            StartTagRaw(""{name}"");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder(""{name}"", this, false);
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
            StartTagRaw(""{name}"");
            {WriteAttrs(attrs)}
            _writer.Get().WriteRaw(""/>"");
        }}
        
        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element.
        /// </summary>
        protected void {CsId(name)}(params Attr[] attrs)
        {{
            StartTagRaw(""{name}"");
            Attrs(attrs);
            _writer.Get().WriteRaw(""/>"");
        }}
        
        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element.
        /// </summary>
        protected void {CsId(name)}(IEnumerable<Attr> attrs)
        {{
            StartTagRaw(""{name}"");
            Attrs(attrs);
            _writer.Get().WriteRaw(""/>"");
        }}
        {SelfClosingTagAttrs(name)}
";

        private string WriteAttrs(string[] attrs)
            => string.Concat(attrs.Select(a => 
                a[0] == '!'
                    ? $@"
            if ({CsId(a)})
            {{
                Attr(Eighty.Attr.Raw(""{a.Substring(1)}""));
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
        [NoDoc]
        protected TagBuilder {CsId(name)}({AttrParams(n)})
        {{
            StartTagRaw(""{name}"");
            Attrs({AttrArgs(n)});
            _writer.Get().WriteRaw('>');
            return new TagBuilder(""{name}"", this, false);
        }}"));

        private string SelfClosingTagAttrs(string name)
            => string.Join("\n", Enumerable.Range(1, 8).Select(n => $@"
        /// <summary>
        /// Write {IndefiniteArticle(name)} {name} element.
        /// </summary>
        [NoDoc]
        protected void {CsId(name)}({AttrParams(n)})
        {{
            StartTagRaw(""{name}"");
            Attrs({AttrArgs(n)});
            _writer.Get().WriteRaw(""/>"");
        }}"));
    }
}
