using System;
using System.Buffers;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Eighty
{
    /// <summary>
    /// NB. Any changes to this file need to be paralleled in HtmlEncodingTextWriter
    /// </summary>
    internal class AsyncHtmlEncodingTextWriter
    {
        private TextWriter _underlyingWriter;
        private char[] _buffer;
        public int _bufLen;

        public AsyncHtmlEncodingTextWriter(TextWriter underlyingWriter)
        {
            _underlyingWriter = underlyingWriter;
            _buffer = ArrayPool<char>.Shared.Rent(2048);
            _bufLen = 0;
        }

        public bool IsDefault()
            => _buffer == null;

        public async Task FlushAndClear()
        {
            await Flush().ConfigureAwait(false);
            ArrayPool<char>.Shared.Return(_buffer);
            _buffer = null;
            _bufLen = 0;
        }

        public Task Write(char c)
        {
            if (c <= '>')
            {
                switch (c)
                {
                    case '<':
                        return WriteRaw("&lt;");
                    case '>':
                        return WriteRaw("&gt;");
                    case '&':
                        return WriteRaw("&amp;");
                    case '"':
                        return WriteRaw("&quot;");
                    case '\'':
                        return WriteRaw("&#39;");
                }
            }
            if (c >= 160 && c < 256)
            {
                return WriteNumericEntity((int)c);
            }
            if (Char.IsSurrogate(c))
            {
                // todo
                return Task.CompletedTask;
            }
            return WriteRaw(c);
        }

        public async Task Write(string s)
        {
            var position = 0;
            while (position < s.Length)
            {
                var chunkLength = SafePrefixLength(s, position);

                await WriteRawImpl(s, position, chunkLength).ConfigureAwait(false);
                position += chunkLength;

                if (position < s.Length)
                {
                    // we're now looking at an HTML-encoding character
                    await Write(s[position]).ConfigureAwait(false);
                    position++;
                }
            }
        }

        public async Task WriteRaw(char c)
        {
            await FlushIfNecessary().ConfigureAwait(false);
            _buffer[_bufLen] = c;
            _bufLen++;
        }

        public Task WriteRaw(string s)
        {
            return WriteRawImpl(s, 0, s.Length);
        }

        private async Task WriteRawImpl(string s, int start, int count)
        {
            while (count > 0)
            {
                var chunkSize = Math.Min(count, _buffer.Length - _bufLen);

                s.CopyTo(start, _buffer, _bufLen, chunkSize);

                count -= chunkSize;
                _bufLen += chunkSize;

                await FlushIfNecessary().ConfigureAwait(false);
            }
        }

        private async Task WriteNumericEntity(int number)
        {
            await WriteRawImpl("&#", 0, 2).ConfigureAwait(false);
            // TODO: this will typically allocate a (small) string.
            // can do better by just appending the characters one by one
            await WriteRaw(number.ToString(CultureInfo.InvariantCulture)).ConfigureAwait(false);
            await WriteRaw(';').ConfigureAwait(false);
        }

        private Task FlushIfNecessary()
        {
            if (_bufLen == _buffer.Length)
            {
                return Flush();
            }
            return Task.CompletedTask;
        }

        public Task Flush()
        {
            var len = _bufLen;
            _bufLen = 0;
            return _underlyingWriter.WriteAsync(_buffer, 0, len);
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
