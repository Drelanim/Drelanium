using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class RemoveMethods
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static void Remove([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            element.ExecuteJavaScript("arguments[0].remove();", element);
        }
    }
}