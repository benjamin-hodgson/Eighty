using System;

namespace Eighty.AspNetCore.Mvc
{
    /// <summary>
    /// Represents a process which can render a <typeparamref name="TModel"/> as <see cref="Html"/>
    /// </summary>
    /// <typeparam name="TModel">The model type</typeparam>
    public interface IEightyView<in TModel>
    {
        /// <summary>
        /// Render a <typeparamref name="TModel"/> as <see cref="Html"/>
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns>The HTML</returns>
        Html Render(TModel model);
    }
}
