using System;
using System.Buffers;
using System.Globalization;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;

namespace Eighty
{
    /// <summary>
    /// This has to be a class because its mutating methods are async and would operate on a copy of the struct if this were a struct
    /// 
    /// NB. Any changes to this file need to be paralleled in HtmlEncodingTextWriter
    /// 
    /// See also https://github.com/dotnet/corefx/blob/3de3cd74ce3d81d13f75928eae728fb7945b6048/src/System.Runtime.Extensions/src/System/Net/WebUtility.cs
    /// </summary>
    internal class AsyncHtmlEncodingTextWriter
    {
        private readonly TextWriter _underlyingWriter;
        private readonly HtmlEncoder _htmlEncoder;
        private char[] _buffer;
        private char[] _scratchpad;
        private int _bufPos;

        public AsyncHtmlEncodingTextWriter(TextWriter underlyingWriter, HtmlEncoder htmlEncoder)
        {
            _underlyingWriter = underlyingWriter;
            _htmlEncoder = htmlEncoder;
            _buffer = ArrayPool<char>.Shared.Rent(2048);
            _scratchpad = ArrayPool<char>.Shared.Rent(_htmlEncoder.MaxOutputCharactersPerInputCharacter);
            _bufPos = 0;
        }

        public async Task FlushAndClear()
        {
            await Flush().ConfigureAwait(false);
            ArrayPool<char>.Shared.Return(_buffer);
            _buffer = null;
            ArrayPool<char>.Shared.Return(_scratchpad);
            _scratchpad = null;
            _bufPos = 0;
        }

        public async Task Write(string s)
        {
            var position = 0;
            while (position < s.Length)
            {
                var safeChunkLength = _htmlEncoder.FindFirstCharacterToEncode(s, position);
                if (safeChunkLength == -1)  // no encoding chars in the input, write the whole string without encoding
                {
                    safeChunkLength = s.Length - position;
                }

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
        private async ValueTask<int> WriteEncodingChars(string s, int position)
        {
            while (position < s.Length)
            {
                var isSurrogatePair = char.IsSurrogatePair(s, position);
                if (char.IsSurrogate(s, position) && !isSurrogatePair)
                {
                    await WriteUnicodeReplacementChar().ConfigureAwait(false);
                    position++;
                    continue;
                }

                var codePoint = char.ConvertToUtf32(s, position);  // won't fail because we checked the precondition
                if (!_htmlEncoder.WillEncode(codePoint))
                {
                    break;
                }
                position += isSurrogatePair ? 2 : 1;

                if (_bufPos + _htmlEncoder.MaxOutputCharactersPerInputCharacter < _buffer.Length)
                {
                    // there's definitely enough space in the buffer, write the encoded html directly
                    EncodeIntoBuffer(codePoint);
                }
                else
                {
                    // write it to the scratchpad first, because it definitely has enough space, then copy over in chunks
                    var numberOfCharactersWritten = EncodeIntoScratchpad(codePoint);
                    await WriteRawImpl(_scratchpad, 0, numberOfCharactersWritten).ConfigureAwait(false);
                }
            }
            return position;
        }

        private unsafe void EncodeIntoBuffer(int codePoint)
        {
            bool success;
            int numberOfCharactersWritten;
            fixed (char* b = _buffer)
            {
                success = _htmlEncoder.TryEncodeUnicodeScalar(codePoint, b + _bufPos, _buffer.Length - _bufPos, out numberOfCharactersWritten);
            }
            if (!success)
            {
                // should be unreachable
                throw new InvalidOperationException("Buffer overflow when encoding HTML. Please report this as a bug in Eighty!");
            }
            _bufPos += numberOfCharactersWritten;
        }

        private unsafe int EncodeIntoScratchpad(int codePoint)
        {
            bool success;
            int numberOfCharactersWritten;
            fixed (char* b = _scratchpad)
            {
                success = _htmlEncoder.TryEncodeUnicodeScalar(codePoint, b, _scratchpad.Length, out numberOfCharactersWritten);
            }
            if (!success)
            {
                // should be unreachable
                throw new InvalidOperationException("Buffer overflow when encoding HTML. Please report this as a bug in Eighty!");
            }
            return numberOfCharactersWritten;
        }

        public async Task WriteRaw(char c)
        {
            await FlushIfNecessary().ConfigureAwait(false);
            _buffer[_bufPos] = c;
            _bufPos++;
        }

        public Task WriteRaw(string s)
        {
            return WriteRawImpl(s, 0, s.Length);
        }

        private Task WriteRawImpl(string s, int start, int count)
        {
            if (count <= _buffer.Length - _bufPos)
            {
                // the whole string fits in the buffer, no need to flush
                s.CopyTo(start, _buffer, _bufPos, count);
                _bufPos += count;
                return Task.CompletedTask;
            }
            return WriteInChunks(s, start, count);
        }
        private async Task WriteInChunks(string s, int start, int count)
        {
            while (count > 0)
            {
                var chunkSize = Math.Min(count, _buffer.Length - _bufPos);

                s.CopyTo(start, _buffer, _bufPos, chunkSize);

                count -= chunkSize;
                start += chunkSize;
                _bufPos += chunkSize;

                await FlushIfNecessary().ConfigureAwait(false);
            }
        }
        private Task WriteRawImpl(char[] arr, int start, int count)
        {
            if (count <= _buffer.Length - _bufPos)
            {
                // the whole string fits in the buffer, no need to flush
                Array.Copy(arr, start, _buffer, _bufPos, count);
                _bufPos += count;
                return Task.CompletedTask;
            }
            return WriteInChunks(arr, start, count);
        }
        private async Task WriteInChunks(char[] arr, int start, int count)
        {
            while (count > 0)
            {
                var chunkSize = Math.Min(count, _buffer.Length - _bufPos);

                Array.Copy(arr, start, _buffer, _bufPos, chunkSize);

                count -= chunkSize;
                start += chunkSize;
                _bufPos += chunkSize;

                await FlushIfNecessary().ConfigureAwait(false);
            }
        }

        private Task WriteUnicodeReplacementChar()
        {
            return WriteRaw(HtmlEncodingHelpers.UNICODE_REPLACEMENT_CHAR);
        }

        private Task FlushIfNecessary()
        {
            if (_bufPos == _buffer.Length)
            {
                return Flush();
            }
            return Task.CompletedTask;
        }

        private Task Flush()
        {
            var len = _bufPos;
            _bufPos = 0;
            return _underlyingWriter.WriteAsync(_buffer, 0, len);
        }
    }
}
