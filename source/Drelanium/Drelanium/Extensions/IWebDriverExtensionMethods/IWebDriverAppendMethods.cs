using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

// ReSharper disable InconsistentNaming

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebDriver" /> types.
    /// </summary>
    public static class IWebDriverAppendMethods
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="parentElementName">The variable name for the parent element that can be used in the window global object.</param>
        /// <param name="childElementName">The variable name for the child element that can be used in the window global object.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static void AppendElementToParent([NotNull] this IWebDriver driver, [NotNull] string parentElementName,
            [NotNull] string childElementName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (parentElementName == null) throw new ArgumentNullException(nameof(parentElementName));
            if (childElementName == null) throw new ArgumentNullException(nameof(childElementName));

            driver.ExecuteJavaScript($"window['{parentElementName}'].appendChild({childElementName}); ");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="parentElement">The parent element.</param>
        /// <param name="childElementName">The variable name for the child element that can be used in the window global object.</param>
        public static void AppendElementToParent([NotNull] this IWebDriver driver, [NotNull] IWebElement parentElement,
            [NotNull] string childElementName)

        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (parentElement == null) throw new ArgumentNullException(nameof(parentElement));
            if (childElementName == null) throw new ArgumentNullException(nameof(childElementName));

            driver.ExecuteJavaScript($"arguments[0].appendChild({childElementName}); ", parentElement);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="parentElement">The parent element.</param>
        /// <param name="childElement">The child element.</param>
        public static void AppendElementToParent([NotNull] this IWebDriver driver, [NotNull] IWebElement parentElement,
            [NotNull] IWebElement childElement)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (parentElement == null) throw new ArgumentNullException(nameof(parentElement));
            if (childElement == null) throw new ArgumentNullException(nameof(childElement));

            driver.ExecuteJavaScript("arguments[0].appendChild(arguments[1]); ", parentElement, childElement);
        }
    }
}