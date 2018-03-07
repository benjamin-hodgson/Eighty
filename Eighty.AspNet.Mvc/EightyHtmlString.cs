using System;
using System.Web;

namespace Eighty.AspNet.Mvc
{
    /// <summary>
    /// An implementation of <see cref="IHtmlString"/> which wraps some <see cref="Html"/>
    /// </summary>
    public class EightyHtmlString : IHtmlString
    {
        private readonly Html _html;

        /// <summary>
        /// Create an <see cref="EightyHtmlString"/>
        /// </summary>
        /// <param name="html">The HTML</param>
        public EightyHtmlString(Html html)
        {
            if (html == null)
            {
                throw new ArgumentNullException(nameof(html));
            }
            _html = html;
        }

        /// <inheritdoc/>
        public string ToHtmlString() => _html.ToString();
    }
}