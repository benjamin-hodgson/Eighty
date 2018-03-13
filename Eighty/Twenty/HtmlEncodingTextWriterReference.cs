using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Eighty.Twenty
{
    internal unsafe readonly struct HtmlEncodingTextWriterReference
    {
        /// <summary>
        /// This is a pointer to an HtmlEncodingTextWriter.
        /// It's safe to have a pointer to the HtmlEncodingTextWriter, even though it's a managed type (it contains arrays),
        /// because it's always stored on the stack (ie it's never fixed).
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
}
