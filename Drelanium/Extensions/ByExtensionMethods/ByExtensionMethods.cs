using Drelanium.SearchContext;
using OpenQA.Selenium;

namespace Drelanium.Extensions.ByExtensionMethods
{
    /// <summary>
    /// Extension methods for <see cref="By"/> types.
    /// </summary>
    public static class ByExtensionMethods
    {
        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static Search Search(this By locator, ISearchContext searchContext)
        {
            return new Search(searchContext);
        }

        /// <summary>
        ///The By method that was used to create the By object.
        ///</summary>
        /// <param name="locator">The locating mechanism to use.</param>
        public static string ByType(this By locator)
        {
            var s = locator.ToString().Remove(locator.ToString().IndexOf(":"));

            return s.Substring(s.IndexOf("By.") + 3);
        }

        /// <summary>
        ///The string value that was used to create the By object.
        /// </summary>
        /// <param name="locator">The locating mechanism to use.</param>
        public static string ByValue(this By locator)
        {
            return locator.ToString().Substring(locator.ToString().IndexOf(":") + 2);
        }
    }
}