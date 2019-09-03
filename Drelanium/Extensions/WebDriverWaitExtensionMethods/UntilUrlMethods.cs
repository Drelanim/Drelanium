using System;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

// ReSharper disable StringLiteralTypo

// ReSharper disable UnusedMember.Global

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilUrlMethods
    {
        /// <summary>
        ///     Waits, until the browser's loaded Url should meet the given condition.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        public static TResult UntilUrl<TResult>(this WebDriverWait wait, Func<string, TResult> condition)
        {
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "loaded url " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.Url(condition));
        }

        /// <summary>
        ///     Waits, until the browser's loaded Url should meet the given condition.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        public static TResult UntilUrl<TResult>(this WebDriverWait wait, Func<Uri, TResult> condition)
        {
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "loaded url " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.Url(condition));
        }

        /// <summary>
        ///     Waits, until the browser's loaded Url should contain the given value.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="urlPart">The URL part the browser is currently displaying.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static bool UntilUrlContains(this WebDriverWait wait, string urlPart)
        {
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "loaded url " +
                            $"to contain ({urlPart})";

            return wait.Until(WebDriverWaitConditions.UrlToContain(urlPart));
        }

        /// <summary>
        ///     Waits, until the browser's loaded Url should not contain the given value.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="uriPartial">
        ///     <inheritdoc cref="Uri.GetLeftPart(UriPartial)" />
        /// </param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        public static TResult UntilUrlLeftPart<TResult>(this WebDriverWait wait, UriPartial uriPartial,
            Func<string, TResult> condition)
        {
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "loaded url's left part " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.UrlLeftPart(uriPartial, condition));
        }

        /// <summary>
        ///     Waits, until the browser's loaded Url should match the regular expression.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="regexPattern">The regular expression pattern.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        public static bool UntilUrlMatches(this WebDriverWait wait, string regexPattern)
        {
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "loaded url " +
                            $"to match with the regular expression ({regexPattern}).";

            return wait.Until(WebDriverWaitConditions.UrlMatches(regexPattern));
        }

        /// <summary>
        ///     Waits, until the browser's loaded Url should not contain the given value.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="urlPart">The URL part the browser is currently displaying.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        public static bool UntilUrlNotContains(this WebDriverWait wait, string urlPart)
        {
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "loaded url " +
                            $"not to contain ({urlPart})";

            return wait.Until(WebDriverWaitConditions.UrlNotToContain(urlPart));
        }

        /// <summary>
        ///     Waits, until the browser's loaded Url should not match the regular expression.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="regexPattern">The regular expression pattern.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        public static bool UntilUrlNotMatches(this WebDriverWait wait, string regexPattern)
        {
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "loaded url " +
                            $"to not match with the regular expression ({regexPattern}).";

            return wait.Until(WebDriverWaitConditions.UrlNotMatches(regexPattern));
        }

        /// <summary>
        ///     Waits, until the browser's loaded Url should not be the given value.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="url">The URL the browser is currently displaying.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        public static bool UntilUrlNotToBe(this WebDriverWait wait, string url)
        {
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "loaded url " +
                            $"not to be ({url})";

            return wait.Until(WebDriverWaitConditions.UrlNotToBe(url));
        }

        /// <summary>
        ///     Waits, until the browser's loaded Url should to be the given value.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="url">The URL the browser is currently displaying.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        public static bool UntilUrlToBe(this WebDriverWait wait, string url)
        {
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "loaded url " +
                            $"to be ({url})";

            return wait.Until(WebDriverWaitConditions.UrlToBe(url));
        }
    }
}