﻿using OpenQA.Selenium;

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
        public static string ByType(this By locator)
        {
            var s = locator.ToString().Remove(locator.ToString().IndexOf(":"));

            return s.Substring(s.IndexOf("By.") + 3);
        }

        /// <summary>
        ///     The string value that was used to create the By object.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        public static string ByValue(this By locator)
        {
            return locator.ToString().Substring(locator.ToString().IndexOf(":") + 2);
        }


        /// <summary>
        ///     <inheritdoc cref="Drelanium.Search" />
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="By" />
        /// </param>
        public static Search Search(this By locator, ISearchContext searchContext)
        {
            return new Search(searchContext);
        }
    }
}