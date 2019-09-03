using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class WrappedDriver
    {
        /// <summary>
        ///     <inheritdoc cref="RemoteWebElement.WrappedDriver" />
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static IWebDriver Driver([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return ((RemoteWebElement) element).WrappedDriver;
        }
    }
}