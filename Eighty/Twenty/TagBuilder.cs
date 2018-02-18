using System;
using System.IO;

namespace Eighty.Twenty
{
    /// <summary>
    /// Represents a "half-open" tag waiting for its children.
    /// Note that the <see cref="TagBuilder"/> MUST be disposed exactly once, immediately after the children have been written.
    /// </summary>
    public readonly struct TagBuilder : IDisposable
    {
        private readonly string _tagName;
        private readonly TextWriter _writer;

        internal TagBuilder(string tagName, TextWriter writer)
        {
            _tagName = tagName;
            _writer = writer;
        }

        /// <summary>
        /// Write the closing tag. This method MUST be called exactly once, immediately after the children have been written.
        /// </summary>
        public void Dispose()
        {
            _writer.Write("</");
            _writer.Write(_tagName);
            _writer.Write(">");
        }
    }
}