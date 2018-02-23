using System;
using System.Buffers;
using System.Globalization;
using System.IO;

namespace Eighty
{
    /// <summary>
    /// A mutable struct, be careful.
    /// 
    /// NB. Any changes to this file need to be paralleled in AsyncHtmlEncodingTextWriter
    /// </summary>
    internal struct HtmlEncodingTextWriter
    {
        private TextWriter _underlyingWriter;
        private char[] _buffer;
        public int _bufLen;

        public HtmlEncodingTextWriter(TextWriter underlyingWriter)
        {
            _underlyingWriter = underlyingWriter;
            _buffer = ArrayPool<char>.Shared.Rent(2048);
            _bufLen = 0;
        }

        public bool IsDefault()
            => _buffer == null;

        public void FlushAndClear()
        {
            Flush();
            ArrayPool<char>.Shared.Return(_buffer);
            _buffer = null;
            _bufLen = 0;
        }

        public void Write(char c)
        {
            if (c <= '>')
            {
                switch (c)
                {
                    case '<':
                        WriteRaw("&lt;");
                        return;
                    case '>':
                        WriteRaw("&gt;");
                        return;
                    case '&':
                        WriteRaw("&amp;");
                        return;
                    case '"':
                        WriteRaw("&quot;");
                        return;
                    case '\'':
                        WriteRaw("&#39;");
                        return;
                }
            }
            if (c >= 160 && c < 256)
            {
                WriteNumericEntity((int)c);
                return;
            }
            if (Char.IsSurrogate(c))
            {
                // todo
                return;
            }
            WriteRaw(c);
        }

        public void Write(string s)
        {
            var position = 0;
            while (position < s.Length)
            {
                var chunkLength = SafePrefixLength(s, position);

                WriteRawImpl(s, position, chunkLength);
                position += chunkLength;

                if (position < s.Length)
                {
                    // we're now looking at an HTML-encoding character
                    Write(s[position]);
                    position++;
                }
            }
        }

        public void WriteRaw(char c)
        {
            FlushIfNecessary();
            _buffer[_bufLen] = c;
            _bufLen++;
        }

        public void WriteRaw(string s)
        {
            WriteRawImpl(s, 0, s.Length);
        }

        private void WriteRawImpl(string s, int start, int count)
        {
            while (count > 0)
            {
                var chunkSize = Math.Min(count, _buffer.Length - _bufLen);

                s.CopyTo(start, _buffer, _bufLen, chunkSize);

                count -= chunkSize;
                _bufLen += chunkSize;

                FlushIfNecessary();
            }
        }

        private void WriteNumericEntity(int number)
        {
            WriteRawImpl("&#", 0, 2);
            // TODO: this will typically allocate a (small) string.
            // can do better by just appending the characters one by one
            WriteRaw(number.ToString(CultureInfo.InvariantCulture));
            WriteRaw(';');
        }

        private void FlushIfNecessary()
        {
            if (_bufLen == _buffer.Length)
            {
                Flush();
            }
        }

        public void Flush()
        {
            var len = _bufLen;
            _bufLen = 0;
            _underlyingWriter.Write(_buffer, 0, len);
        }



        private static int SafePrefixLength(string s, int start)
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
