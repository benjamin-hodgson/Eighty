namespace Eighty.Twenty;

/// <summary>
/// Represents a process which can render a <typeparamref name="TModel"/> using an <see cref="HtmlBuilder"/>
/// </summary>
/// <typeparam name="TModel">The model type</typeparam>
public interface IHtmlBuilderRenderer<in TModel>
{
    /// <summary>
    /// Get an <see cref="HtmlBuilder"/> which can render <paramref name="model"/> as HTML
    /// </summary>
    /// <param name="model">The model</param>
    /// <returns>A <see cref="HtmlBuilder"/></returns>
    HtmlBuilder GetHtmlBuilder(TModel model);
}
