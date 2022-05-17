using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;

namespace Eighty;

/// <summary>
/// A mutable struct, be careful.
/// 
/// Because this struct is a managed type (it contains arrays) and is referenced by pointer
/// (see HtmlEncodingTextWriterReference), it must always stay on the stack so that the GC
/// can reach the contained arrays.
/// 
/// NB. Any changes to this file need to be paralleled in AsyncHtmlEncodingTextWriter.
/// </summary>
[StructLayout(LayoutKind.Auto)]
internal unsafe struct HtmlEncodingTextWriter
{
    private readonly TextWriter _underlyingWriter;
    private readonly HtmlEncoder _htmlEncoder;

    // invariant: _start <= _current < _end
    // invariant: _start points to the same location as _underlyingBuffer
    private readonly char[] _underlyingBuffer;
    private readonly char* _start;
    private char* _current;
    private readonly char* _end;

    public HtmlEncodingTextWriter(TextWriter underlyingWriter, HtmlEncoder htmlEncoder, char[] underlyingBuffer, char* start, int length)
    {
        _underlyingWriter = underlyingWriter;
        _htmlEncoder = htmlEncoder;
        _underlyingBuffer = underlyingBuffer;
        _start = _current = start;
        _end = start + length;
    }

    public void Write(string s)
    {
        fixed (char* str = s)
        {
            var start = str;
            var end = str + s.Length;

            while (start < end)
            {
                var len = (int)(end - start);
                var safeChunkLength = _htmlEncoder.FindFirstCharacterToEncode(start, len);
                if (safeChunkLength == -1)  // no encoding chars in the input, write the whole string without encoding
                {
                    safeChunkLength = len;
                }

                WriteRawImpl(ref start, start + safeChunkLength);

                // we're now looking at an HTML-encoding character
                WriteEncodingChars(ref start, end);
            }
        }
    }

    /// <summary>
    /// Consume a run of HTML-encoding characters from the string
    /// </summary>
    private void WriteEncodingChars(ref char* start, char* end)
    {
        while (start < end)
        {
            int codePoint;
            int numberOfCharactersConsumed;
            if (end - start > 1 && char.IsSurrogatePair(*start, *(start + 1)))
            {
                codePoint = char.ConvertToUtf32(*start, *(start + 1));
                numberOfCharactersConsumed = 2;
            }
            else if (char.IsSurrogate(*start))
            {
                WriteUnicodeReplacementChar();
                start += 1;
                continue;
            }
            else
            {
                codePoint = (int)*start;
                numberOfCharactersConsumed = 1;
            }

            if (!_htmlEncoder.WillEncode(codePoint))
            {
                break;
            }

            if (!_htmlEncoder.TryEncodeUnicodeScalar(codePoint, _current, (int)(_end - _current), out var numberOfCharactersWritten))
            {
                Flush();  // _current gets reset here - don't try to deduplicate (_end - _current)!
                if (!_htmlEncoder.TryEncodeUnicodeScalar(codePoint, _current, (int)(_end - _current), out numberOfCharactersWritten))
                {
                    throw new InvalidOperationException("Buffer overflow when encoding HTML. Please report this as a bug in Eighty!");
                }
            }
            start += numberOfCharactersConsumed;
            _current += numberOfCharactersWritten;
        }
    }

    public void WriteRaw(char c)
    {
        FlushIfNecessary();
        *_current = c;
        _current++;
    }

    public void WriteRaw(string s)
    {
        fixed (char* str = s)
        {
            var start = str;
            WriteRawImpl(ref start, str + s.Length);
        }
    }

    private void WriteRawImpl(ref char* start, char* end)
    {
        if (end - start <= _end - _current)
        {
            // the whole string fits in the buffer, no need to flush

            for (; start < end; start++, _current++)
            {
                *_current = *start;
            }
            return;
        }
        WriteInChunks(ref start, end);
    }
    private void WriteInChunks(ref char* start, char* end)
    {
        while (start < end)
        {
            var chunkSize = Math.Min(end - start, _end - _current);
            var chunkEnd = start + chunkSize;

            for (; start < chunkEnd; start++, _current++)
            {
                *_current = *start;
            }

            FlushIfNecessary();
        }
    }

    private void WriteUnicodeReplacementChar()
    {
        WriteRaw(HtmlEncodingHelpers.UNICODE_REPLACEMENT_CHAR);
    }

    private void FlushIfNecessary()
    {
        if (_current == _end)
        {
            Flush();
        }
    }

    public void Flush()
    {
        var len = _current - _start;
        _current = _start;
        _underlyingWriter.Write(_underlyingBuffer, 0, (int)len);
    }
}
