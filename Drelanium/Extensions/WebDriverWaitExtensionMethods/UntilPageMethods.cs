using System;
using System.ComponentModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium


{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilPageMethods
    {
        /// <summary>
        ///     Waits until the browser's loaded the page and the Url has met the given condition.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="urlCondition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static bool UntilPageHasLoaded(this WebDriverWait wait, Func<Uri, bool> urlCondition)
        {
            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until page has been successfully loaded and the url has met the given condition.";

            return wait.Until(WebDriverWaitConditions.PageHasLoaded(urlCondition));
        }


        /// <summary>
        ///     Waits until the browser's loaded the page without domain cookies and the Url has met the given condition.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="urlCondition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static bool UntilPageHasLoadedWithoutCookies(this WebDriverWait wait, Func<Uri, bool> urlCondition)
        {
            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until page has been successfully loaded without cookies and the url has met the given condition.";

            return wait.Until(WebDriverWaitConditions.PageHasLoadedWithoutDomainCookies(urlCondition));
        }
    }
}