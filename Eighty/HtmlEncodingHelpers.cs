namespace Eighty
{
    internal static class HtmlEncodingHelpers
    {
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
        private static bool ShouldEncode(char c)
            => (c <= '>' && (c == '<' || c == '>' || c == '&' || c == '"' || c == '\''))
            || c >= 160
            || char.IsSurrogate(c);
    }
}