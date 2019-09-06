using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="ITargetLocator" /> types.
    /// </summary>
    public static class ITargetLocatorExtensionMethods
    {
        /// <summary>
        ///     <inheritdoc cref="Drelanium.Alert" />
        /// </summary>
        /// <param name="targetLocator">   ...Description to be added...</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Alert Alert([NotNull] this ITargetLocator targetLocator, [NotNull] IWebDriver driver)
        {
            if (targetLocator == null) throw new ArgumentNullException(nameof(targetLocator));
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new Alert(driver);
        }
    }
}