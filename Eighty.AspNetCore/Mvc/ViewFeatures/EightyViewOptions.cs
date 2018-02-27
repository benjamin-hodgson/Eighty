using Microsoft.Extensions.Options;

namespace Eighty.AspNetCore.Mvc.ViewFeatures
{
    public class EightyViewOptions
    {
        public EightyViewCollection ViewCollection { get; } = new EightyViewCollection();
    }
}
