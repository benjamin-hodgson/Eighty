using System.Text.Encodings.Web;

namespace Eighty
{
    internal static class HtmlEncodingHelpers
    {
        public const string UNICODE_REPLACEMENT_CHAR = "\uFFFD";

        public static unsafe int FindFirstCharacterToEncode(this HtmlEncoder htmlEncoder, string s, int start)
        {
            fixed (char* t = s)
            {
                return htmlEncoder.FindFirstCharacterToEncode(t + start, s.Length - start);
            }
        }
    }
}
