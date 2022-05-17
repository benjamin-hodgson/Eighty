using System;
using System.Buffers;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Eighty;

/// <summary>
/// This has to be a class because its mutating methods are async and would operate on a copy of the struct if this were a struct
/// 
/// NB. Any changes to this file need to be paralleled in HtmlEncodingTextWriter
/// </summary>
internal class AsyncHtmlEncodingTextWriter
{
    private readonly TextWriter _underlyingWriter;
    private readonly HtmlEncoder _htmlEncoder;
    private char[] _buffer;
    private int _bufPos;

    public AsyncHtmlEncodingTextWriter(TextWriter underlyingWriter, HtmlEncoder htmlEncoder)
    {
        _underlyingWriter = underlyingWriter;
        _htmlEncoder = htmlEncoder;
        _buffer = ArrayPool<char>.Shared.Rent(4096);
        _bufPos = 0;
    }

    public async Task FlushAndClear()
    {
        await Flush().ConfigureAwait(false);
        ArrayPool<char>.Shared.Return(_buffer);
        _buffer = null;
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
            int codePoint;
            int numberOfCharactersConsumed;
            if (char.IsSurrogatePair(s, position))
            {
                codePoint = char.ConvertToUtf32(s, position);
                numberOfCharactersConsumed = 2;
            }
            else if (char.IsSurrogate(s, position))
            {
                await WriteUnicodeReplacementChar().ConfigureAwait(false);
                position += 1;
                continue;
            }
            else
            {
                codePoint = char.ConvertToUtf32(s, position);
                numberOfCharactersConsumed = 1;
            }

            if (!_htmlEncoder.WillEncode(codePoint))
            {
                break;
            }

            if (!_htmlEncoder.TryEncodeUnicodeScalar(codePoint, _buffer, _bufPos, out var numberOfCharactersWritten))
            {
                await Flush().ConfigureAwait(false);
                if (!_htmlEncoder.TryEncodeUnicodeScalar(codePoint, _buffer, _bufPos, out numberOfCharactersWritten))
                {
                    throw new InvalidOperationException("Buffer overflow when encoding HTML. Please report this as a bug in Eighty!");
                }
            }
            position += numberOfCharactersConsumed;
            _bufPos += numberOfCharactersWritten;
        }
        return position;
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
