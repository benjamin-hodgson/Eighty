namespace Eighty
{
    internal static class HtmlEncodingHelpers
    {
        public const string UNICODE_REPLACEMENT_CHAR = "\uFFFD";

        public static bool IsBasicMultilingualPlane(int codePoint)
            => codePoint <= 0x00FFFF;

        public static int SafePrefixLength(string s, int start)
        {
            int i;
            for (i = start; i < s.Length; i++)
            {
                if (ShouldEncode(s[i]))
                {
                    break;
                }
            }
            return i - start;
        }

        public static bool ShouldEncode(char c)
            => (c <= '>' && (c == '<' || c == '>' || c == '&' || c == '"' || c == '\''))
            || char.IsSurrogate(c);
    }
}