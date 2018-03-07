using System;
using System.Web.Mvc;
using System.Web.WebPages;
using Eighty.Twenty;

namespace Eighty.AspNet.Mvc
{
    public static class HtmlHelperExtensions
    {
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
