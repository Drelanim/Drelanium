﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

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
        public static void AppendElementToParent(this IWebDriver driver, string parentElementName,
            string childElementName)
        {
            driver.ExecuteJavaScript($"window['{parentElementName}'].appendChild({childElementName}); .");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="parentElement">The parent element.</param>
        /// <param name="childElementName">The variable name for the child element that can be used in the window global object.</param>
        public static void AppendElementToParent(this IWebDriver driver, IWebElement parentElement,
            string childElementName)
        {
            driver.ExecuteJavaScript($"arguments[0].appendChild({childElementName}); ", parentElement);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="parentElement">The parent element.</param>
        /// <param name="childElement">The child element.</param>
        public static void AppendElementToParent(this IWebDriver driver, IWebElement parentElement,
            IWebElement childElement)
        {
            driver.ExecuteJavaScript("arguments[0].appendChild(arguments[1]); ", parentElement, childElement);
        }
    }
}