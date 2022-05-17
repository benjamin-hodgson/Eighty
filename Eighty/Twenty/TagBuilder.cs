using System;

namespace Eighty.Twenty;

/// <summary>
/// Represents a "half-open" tag waiting for its children.
/// Note that the <see cref="TagBuilder"/> MUST be disposed exactly once, immediately after the children have been written.
/// </summary>
public readonly struct TagBuilder : IDisposable
{
    private readonly string _tagName;
    private readonly HtmlBuilder _builder;
    private readonly bool _shouldEncode;

    internal TagBuilder(string tagName, HtmlBuilder builder, bool shouldEncode)
    {
        _tagName = tagName;
        _builder = builder;
        _shouldEncode = shouldEncode;
    }

    /// <summary>
    /// Write the closing tag. This method MUST be called exactly once, immediately after the children have been written.
    /// </summary>
    public void Dispose()
    {
        _builder.Raw("</");
        if (_shouldEncode)
        {
            _builder.Text(_tagName);
        }
        else
        {
            _builder.Raw(_tagName);
        }
        _builder.Raw(">");
    }
}
