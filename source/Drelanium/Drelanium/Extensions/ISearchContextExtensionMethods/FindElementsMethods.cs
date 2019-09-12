using System;
using System.Collections.ObjectModel;
using JetBrains.Annotations;
using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium
{
    /// <summary>
    ///     Extension methods for <see cref="ISearchContext" /> types.
    /// </summary>
    public static class FindElementsMethods
    {
        /// <summary>
        ///     <inheritdoc cref="ISearchContext.FindElements(By)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during the method exeuction.
        /// </param>
        public static ReadOnlyCollection<IWebElement> FindElements(
            [NotNull] this ISearchContext searchContext,
            [NotNull] By locator,
            [CanBeNull] Logger logger)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            logger?.Information($"Attempting to Find element with ({locator}).");

            var elements = searchContext.FindElements(locator);

            logger?.Information($"Found ({elements.Count}) number of elements with ({locator}).");

            return elements;
        }
    }
}