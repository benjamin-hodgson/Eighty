using System;
using System.Buffers;
using System.IO;
using System.Text;

namespace Eighty;

internal class PooledStringWriter : TextWriter
{
    private const int _initialCapacity = 4096;
    private char[]? _buffer;
    private int _length;

    public PooledStringWriter()
    {
        _buffer = ArrayPool<char>.Shared.Rent(_initialCapacity);
        _length = 0;
    }

    public override string ToString() => new(_buffer, 0, _length);

    public override void Write(char value)
    {
        GrowIfNecessary(1);
        _buffer![_length] = value;
        _length++;
    }

    public override void Write(string value)
    {
        GrowIfNecessary(value.Length);
        value.CopyTo(0, _buffer, _length, value.Length);
        _length += value.Length;
    }

    public override void Write(char[] buffer, int index, int count)
    {
        GrowIfNecessary(count);
        Array.Copy(buffer, index, _buffer, _length, count);
        _length += count;
    }

    protected override void Dispose(bool disposing)
    {
        if (_buffer != null)
        {
            ArrayPool<char>.Shared.Return(_buffer);
            _buffer = null;
        }

        base.Dispose(disposing);
    }

    public override Encoding Encoding => Encoding.Default;

    private void GrowIfNecessary(int minimumSpace)
    {
        var minimumLength = _length + minimumSpace;
        if (minimumLength > _buffer!.Length)
        {
            var newBufferSize = Math.Max(minimumLength, _buffer.Length * 2);
            var newBuffer = ArrayPool<char>.Shared.Rent(newBufferSize);

            Array.Copy(_buffer, newBuffer, _length);

            ArrayPool<char>.Shared.Return(_buffer);
            _buffer = newBuffer;
        }
    }
}
