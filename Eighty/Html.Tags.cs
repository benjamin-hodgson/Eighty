namespace Eighty
{
    public abstract partial class Html
    {
        private static readonly Html _doctype = Raw("<!DOCTYPE HTML>");

        /// <summary>
        /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html doctype() => _doctype;

        /// <summary>
        /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble and create an <c>html</c> tag with children.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html doctypeHtml_(params Html[] children)
            => _(doctype(), html_(children));
        /// <summary>
        /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble and create an <c>html</c> tag with children.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html doctypeHtml_(Html child1)
            => _(doctype(), html_(child1));
        /// <summary>
        /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble and create an <c>html</c> tag with children.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html doctypeHtml_(Html child1, Html child2)
            => _(doctype(), html_(child1, child2));
        /// <summary>
        /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble and create an <c>html</c> tag with children.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html doctypeHtml_(Html child1, Html child2, Html child3)
            => _(doctype(), html_(child1, child2, child3));
        /// <summary>
        /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble and create an <c>html</c> tag with children.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html doctypeHtml_(Html child1, Html child2, Html child3, Html child4)
            => _(doctype(), html_(child1, child2, child3, child4));
        /// <summary>
        /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble and create an <c>html</c> tag with children.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html doctypeHtml_(Html child1, Html child2, Html child3, Html child4, Html child5)
            => _(doctype(), html_(child1, child2, child3, child4, child5));
        /// <summary>
        /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble and create an <c>html</c> tag with children.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html doctypeHtml_(Html child1, Html child2, Html child3, Html child4, Html child5, Html child6)
            => _(doctype(), html_(child1, child2, child3, child4, child5, child6));
        /// <summary>
        /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble and create an <c>html</c> tag with children.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html doctypeHtml_(Html child1, Html child2, Html child3, Html child4, Html child5, Html child6, Html child7)
            => _(doctype(), html_(child1, child2, child3, child4, child5, child6, child7));
        /// <summary>
        /// Write the <c>&lt;!DOCTYPE HTML&gt;</c> preamble and create an <c>html</c> tag with children.
        /// </summary>
        /// <returns>An instance of <see cref="Html"/>.</returns>
        public static Html doctypeHtml_(Html child1, Html child2, Html child3, Html child4, Html child5, Html child6, Html child7, Html child8)
            => _(doctype(), html_(child1, child2, child3, child4, child5, child6, child7, child8));
    }
}