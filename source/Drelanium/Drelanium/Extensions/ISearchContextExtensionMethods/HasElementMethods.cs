using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

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
            [NotNull] this ISearchContext searchContext,
            [NotNull] By locator)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            return searchContext.FindElements(locator).Count > 0;
        }
    }
}