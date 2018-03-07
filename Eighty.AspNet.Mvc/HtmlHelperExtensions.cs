using System;
using System.Web.Mvc;
using System.Web.WebPages;
using Eighty.Twenty;

namespace Eighty.AspNet.Mvc
{
    /// <summary>
    /// Extension methods to enable Eighty to interoperate with <see cref="HtmlHelper"/>
    /// </summary>
    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// Render some <see cref="Html"/>
        /// </summary>
        /// <param name="htmlHelper">The <see cref="HtmlHelper"/></param>
        /// <param name="html">The <see cref="Html"/> to render</param>
        /// <returns>A <see cref="HelperResult"/> which renders <paramref name="html"/> when executed.</returns>
        public static HelperResult Html(this HtmlHelper htmlHelper, Html html)
        {
            if (htmlHelper == null)
            {
                throw new ArgumentNullException(nameof(htmlHelper));
            }
            if (html == null)
            {
                throw new ArgumentNullException(nameof(html));
            }
            return new HelperResult(html.Write);
        }

        /// <summary>
        /// Render the output of a <see cref="HtmlBuilder"/>
        /// </summary>
        /// <param name="htmlHelper">The <see cref="HtmlHelper"/></param>
        /// <param name="htmlBuilder">The <see cref="HtmlBuilder"/> to render</param>
        /// <returns>A <see cref="HelperResult"/> which renders <paramref name="htmlBuilder"/> when executed.</returns>
        public static HelperResult HtmlBuilder(this HtmlHelper htmlHelper, HtmlBuilder htmlBuilder)
        {
            if (htmlHelper == null)
            {
                throw new ArgumentNullException(nameof(htmlHelper));
            }
            if (htmlBuilder == null)
            {
                throw new ArgumentNullException(nameof(htmlBuilder));
            }
            return new HelperResult(htmlBuilder.Write);
        }
    }
}
