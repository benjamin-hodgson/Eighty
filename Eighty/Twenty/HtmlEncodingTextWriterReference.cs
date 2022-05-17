using System;
using System.Runtime.CompilerServices;

namespace Eighty.Twenty;

internal readonly unsafe struct HtmlEncodingTextWriterReference
{
    /// <summary>
    /// This is a pointer to an HtmlEncodingTextWriter.
    /// It's safe to have a pointer to the HtmlEncodingTextWriter, even though it's a managed type (it contains arrays),
    /// because it's stored on the stack (so the GC can always reach it) and the pointer won't live longer than
    /// the local variable it points to.
    /// </summary>
    private readonly void* _writer;

    public HtmlEncodingTextWriterReference(ref HtmlEncodingTextWriter writer)
    {
        _writer = Unsafe.AsPointer(ref writer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref HtmlEncodingTextWriter Get()
    {
        return ref Unsafe.AsRef<HtmlEncodingTextWriter>(_writer);
    }

    public bool IsDefault() => new IntPtr(_writer) == IntPtr.Zero;
}
