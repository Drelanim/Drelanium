using System;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium
{
    /// <summary>
    ///     Collection of methods, that provides exit condition for the <see cref="WebDriverWait" /> type's Until(
    ///     <see cref="Func{T,TResult}" />) method.
    /// </summary>
    public static partial class WebDriverWaitConditions
    {
        /// <summary>
        ///     The browser's title should meet the condition.
        /// </summary>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static Func<IWebDriver, TResult> Title<TResult>(
            [NotNull] Func<string, TResult> condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(driver.Title);
        }

        /// <summary>
        ///     The browser's title should match the regular expression.
        /// </summary>
        /// <param name="regexPattern">The regular expression pattern.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        public static Func<IWebDriver, bool> TitleMatches([NotNull] string regexPattern)
        {
            if (regexPattern == null) throw new ArgumentNullException(nameof(regexPattern));

            return driver => new Regex(regexPattern, RegexOptions.IgnoreCase).Match(driver.Title).Success;
        }

        /// <summary>
        ///     The browser's title should not match the regular expression.
        /// </summary>
        /// <param name="regexPattern">The regular expression pattern.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        public static Func<IWebDriver, bool> TitleNotMatches([NotNull] string regexPattern)
        {
            if (regexPattern == null) throw new ArgumentNullException(nameof(regexPattern));

            return driver => !new Regex(regexPattern, RegexOptions.IgnoreCase).Match(driver.Title).Success;
        }

        /// <summary>
        ///     The browser's title should be equal to the given value.
        /// </summary>
        /// <param name="title">The title of the current browser window.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static Func<IWebDriver, bool> TitleNotToBe([NotNull] string title)
        {
            if (title == null) throw new ArgumentNullException(nameof(title));

            return driver => driver.Title != title;
        }

        /// <summary>
        ///     The browser's title should not contain the given value.
        /// </summary>
        /// <param name="titlePart">The title part of the current browser window.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static Func<IWebDriver, bool> TitleNotToContain([NotNull] string titlePart)
        {
            if (titlePart == null) throw new ArgumentNullException(nameof(titlePart));

            return driver => !driver.Title.Contains(titlePart);
        }

        /// <summary>
        ///     The browser's title should be the given value.
        /// </summary>
        /// <param name="title">The title of the current browser window.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static Func<IWebDriver, bool> TitleToBe([NotNull] string title)
        {
            if (title == null) throw new ArgumentNullException(nameof(title));

            return driver => driver.Title == title;
        }

        /// <summary>
        ///     The browser's title should contain the given value.
        /// </summary>
        /// <param name="titlePart">The title part of the current browser window.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static Func<IWebDriver, bool> TitleToContain([NotNull] string titlePart)
        {
            if (titlePart == null) throw new ArgumentNullException(nameof(titlePart));

            return driver => driver.Title.Contains(titlePart);
        }
    }
}