using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="By" /> types.
    /// </summary>
    public static class ByExtensionMethods
    {
        /// <summary>
        ///     The By method that was used to create the By object.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        public static string ByType([NotNull] this By locator)
        {
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            var s = locator.ToString().Remove(locator.ToString().IndexOf(":"));

            return s.Substring(s.IndexOf("By") + 3);
        }

        /// <summary>
        ///     The string value that was used to create the By object.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        public static string ByValue([NotNull] this By locator)
        {
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            return locator.ToString().Substring(locator.ToString().IndexOf(":") + 2);
        }
    }
}