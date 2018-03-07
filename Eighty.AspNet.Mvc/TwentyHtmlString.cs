using System;
using System.Web;
using Eighty.Twenty;

namespace Eighty.AspNet.Mvc
{
    /// <summary>
    /// An implementation of <see cref="IHtmlString"/> which wraps an <see cref="HtmlBuilder"/>
    /// </summary>
    public class TwentyHtmlString : IHtmlString
    {
        private readonly HtmlBuilder _builder;

        /// <summary>
        /// Create a <see cref="TwentyHtmlString"/>
        /// </summary>
        /// <param name="builder">The <see cref="HtmlBuilder"/></param>
        public TwentyHtmlString(HtmlBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }
            _builder = builder;
        }

        /// <inheritdoc/>
        public string ToHtmlString() => _builder.ToString();
    }
}