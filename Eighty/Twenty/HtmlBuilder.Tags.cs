using System;

namespace Eighty.Twenty
{
    public abstract partial class HtmlBuilder
    {
        /// <summary>
        /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble.
        /// </summary>
        protected void doctype()
        {
            Raw("<!DOCTYPE HTML>");
        }
        /// <summary>
        /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble.
        /// </summary>
        protected TagBuilder doctypeHtml()
        {
            doctype();
            return html();
        }
    }
}