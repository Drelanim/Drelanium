﻿using OpenQA.Selenium;

namespace Drelanium
{
    /// <summary>
    ///     Extension methods for <see cref="ISearchContext" /> types.
    /// </summary>
    public static class HasElementMethods
    {
        /// <summary>
        ///     Checks if the element can or cannot be found within the SearchContext.
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        public static bool HasElement(
            this ISearchContext searchContext,
            By locator)
        {
            return searchContext.FindElements(locator).Count > 0;
        }
    }
}