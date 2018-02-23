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
    /// 
    /// See also https://github.com/dotnet/corefx/blob/3de3cd74ce3d81d13f75928eae728fb7945b6048/src/System.Runtime.Extensions/src/System/Net/WebUtility.cs
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

        public async Task Write(string s)
        {
            var position = 0;
            while (position < s.Length)
            {
                var safeChunkLength = HtmlEncodingHelpers.SafePrefixLength(s, position);

                await WriteRawImpl(s, position, safeChunkLength).ConfigureAwait(false);
                position += safeChunkLength;

                if (position < s.Length)
                {
                    // we're now looking at an HTML-encoding character
                    position = await WriteEncodingChars(s, position).ConfigureAwait(false);
                }
            }
        }

        /// <summary>
        /// Consume a run of HTML-encoding characters from the string
        /// </summary>
        /// <returns>The new position</returns>
        private async Task<int> WriteEncodingChars(string s, int position)  // todo: ValueTask?
        {
            while (position < s.Length && HtmlEncodingHelpers.ShouldEncode(s[position]))
            {
                var c = s[position];
                position++;
                switch (c)
                {
                    case '<':
                        await WriteRaw("&lt;").ConfigureAwait(false);
                        continue;
                    case '>':
                        await WriteRaw("&gt;").ConfigureAwait(false);
                        continue;
                    case '&':
                        await WriteRaw("&amp;").ConfigureAwait(false);
                        continue;
                    case '"':
                        await WriteRaw("&quot;").ConfigureAwait(false);
                        continue;
                    case '\'':
                        await WriteRaw("&#39;").ConfigureAwait(false);
                        continue;
                }
                if (c >= 160 && c < 256)
                {
                    await WriteNumericEntity((int)c).ConfigureAwait(false);
                    continue;
                }
                if (char.IsSurrogate(c))
                {
                    if (position >= s.Length)  // there's no low surrogate
                    {
                        await WriteUnicodeReplacementChar().ConfigureAwait(false);
                        continue;
                    }

                    var highSurrogate = c;
                    var lowSurrogate = s[position];
                    // don't increment position until we're sure we're going to consume lowSurrogate

                    if (!char.IsSurrogatePair(highSurrogate, lowSurrogate))
                    {
                        await WriteUnicodeReplacementChar().ConfigureAwait(false);
                        continue;
                    }

                    position++;
                    await WriteNumericEntity(char.ConvertToUtf32(highSurrogate, lowSurrogate)).ConfigureAwait(false);
                    continue;
                }

                // shouldn't be reachable, because we checked ShouldEncode at the start of the while loop
                await WriteRaw(c).ConfigureAwait(false);
            }
            return position;
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

        private Task WriteUnicodeReplacementChar()
        {
            return WriteRaw(HtmlEncodingHelpers.UNICODE_REPLACEMENT_CHAR);
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

        private Task Flush()
        {
            var len = _bufLen;
            _bufLen = 0;
            return _underlyingWriter.WriteAsync(_buffer, 0, len);
        }
    }
}
