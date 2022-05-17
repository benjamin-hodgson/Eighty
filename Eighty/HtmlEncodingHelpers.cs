using System.Text.Encodings.Web;

namespace Eighty;

internal static class HtmlEncodingHelpers
{
    public const string UNICODE_REPLACEMENT_CHAR = "\uFFFD";

    public static unsafe bool TryEncodeUnicodeScalar(this HtmlEncoder htmlEncoder, int codePoint, char[] buffer, int bufPos, out int numberOfCharactersWritten)
    {
        fixed (char* b = buffer)
        {
            return htmlEncoder.TryEncodeUnicodeScalar(codePoint, b + bufPos, buffer.Length - bufPos, out numberOfCharactersWritten);
        }
    }
    public static unsafe int FindFirstCharacterToEncode(this HtmlEncoder htmlEncoder, string s, int start)
    {
        fixed (char* t = s)
        {
            return htmlEncoder.FindFirstCharacterToEncode(t + start, s.Length - start);
        }
    }
}
