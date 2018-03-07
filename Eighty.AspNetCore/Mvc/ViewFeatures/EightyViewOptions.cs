namespace Eighty.AspNetCore.Mvc.ViewFeatures
{
    /// <summary>
    /// Options for the <see cref="EightyViewEngine"/>
    /// </summary>
    public class EightyViewOptions
    {
        /// <summary>
        /// The view collection
        /// </summary>
        /// <returns>The view collection</returns>
        public EightyViewCollection ViewCollection { get; } = new EightyViewCollection();
    }
}
