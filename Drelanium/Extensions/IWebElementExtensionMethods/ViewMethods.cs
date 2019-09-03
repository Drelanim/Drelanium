using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class ViewMethods
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="behavior">...Description to be added...</param>
        /// <param name="block">...Description to be added...</param>
        /// <param name="inline">...Description to be added...</param>
        public static IWebElement ScrollIntoView([NotNull] this IWebElement element, [NotNull] string behavior = "auto",
            [NotNull] string block = "center", [NotNull] string inline = "center")
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (behavior == null) throw new ArgumentNullException(nameof(behavior));
            if (block == null) throw new ArgumentNullException(nameof(block));
            if (inline == null) throw new ArgumentNullException(nameof(inline));

            element.ExecuteJavaScript(
                $"arguments[0].scrollIntoView({{behavior: '{behavior}', block: '{block}', inline: '{inline}'}});",
                element);

            return element;
        }
    }
}