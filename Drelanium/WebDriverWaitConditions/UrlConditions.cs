using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
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
        ///     The browser's loaded the page and the Url has met the given condition.
        /// </summary>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, bool> PageHasLoaded(Func<Uri, bool> condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => driver.Document().ReadyState == DocumentReadyState.complete &&
                             condition(driver.Url());
        }

        /// <summary>
        ///     The browser's loaded the page and the Url has met the given condition.
        /// </summary>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, bool> PageHasLoaded(Func<string, bool> condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return PageHasLoaded(uri => condition(uri.AbsoluteUri));
        }

        /// <summary>
        ///     The browser's loaded the page without cookies and the Url has met the given condition.
        /// </summary>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, bool> PageHasLoadedWithoutDomainCookies(Func<Uri, bool> condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver =>
            {
                driver.Manage().Cookies.DeleteAllCookies();

                if (driver.Document().ReadyState == DocumentReadyState.complete &&
                    driver.Manage().Cookies.AllCookies.Count(cookie => cookie.Domain == driver.Url().Host) == 0 &&
                    condition(driver.Url()))
                {
                    driver.Navigate().Refresh();
                    return true;
                }

                return false;
            };
        }

        /// <summary>
        ///     The browser's loaded the page without cookies and the Url has met the given condition.
        /// </summary>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, bool> PageHasLoadedWithoutDomainCookies(Func<string, bool> condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return PageHasLoadedWithoutDomainCookies(uri => condition(uri.AbsoluteUri));
        }

        /// <summary>
        ///     The browser's loaded Url should meet the given condition.
        /// </summary>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static Func<IWebDriver, TResult> Url<TResult>(Func<string, TResult> condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(driver.Url);
        }

        /// <summary>
        ///     The browser's loaded Url should meet the given condition.
        /// </summary>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static Func<IWebDriver, TResult> Url<TResult>(Func<Uri, TResult> condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(driver.Url());
        }

        /// <summary>
        ///     The browser's loaded Url's given left part should meet the given condition.
        /// </summary>
        /// <param name="uriPartial">
        ///     <inheritdoc cref="Uri.GetLeftPart(UriPartial)" />
        /// </param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static Func<IWebDriver, TResult> UrlLeftPart<TResult>(UriPartial uriPartial,
            Func<string, TResult> condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            if (!Enum.IsDefined(typeof(UriPartial), uriPartial))
                throw new InvalidEnumArgumentException(nameof(uriPartial), (int) uriPartial, typeof(UriPartial));

            return driver => condition(driver.Url().GetLeftPart(uriPartial));
        }

        /// <summary>
        ///     The browser's loaded Url should match the regular expression.
        /// </summary>
        /// <param name="regexPattern">The regular expression pattern.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        public static Func<IWebDriver, bool> UrlMatches(string regexPattern)
        {
            if (regexPattern == null) throw new ArgumentNullException(nameof(regexPattern));

            return driver => new Regex(regexPattern, RegexOptions.IgnoreCase).Match(driver.Url).Success;
        }

        /// <summary>
        ///     The browser's loaded Url should not match the regular expression.
        /// </summary>
        /// <param name="regexPattern">The regular expression pattern.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        public static Func<IWebDriver, bool> UrlNotMatches(string regexPattern)
        {
            if (regexPattern == null) throw new ArgumentNullException(nameof(regexPattern));

            return driver => !new Regex(regexPattern, RegexOptions.IgnoreCase).Match(driver.Url).Success;
        }

        /// <summary>
        ///     The browser's loaded Url should not be the given value.
        /// </summary>
        /// <param name="url">The URL the browser is currently displaying.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static Func<IWebDriver, bool> UrlNotToBe(string url)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));

            return driver => driver.Url != url;
        }

        /// <summary>
        ///     The browser's loaded Url should not contain the given value.
        /// </summary>
        /// <param name="urlPart">The URL part the browser is currently displaying.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static Func<IWebDriver, bool> UrlNotToContain(string urlPart)
        {
            if (urlPart == null) throw new ArgumentNullException(nameof(urlPart));

            return driver => !driver.Url.Contains(urlPart);
        }

        /// <summary>
        ///     The browser's loaded Url should be the given value.
        /// </summary>
        /// <param name="url">The URL the browser is currently displaying.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static Func<IWebDriver, bool> UrlToBe(string url)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));

            return driver => driver.Url == url;
        }

        /// <summary>
        ///     The browser's loaded Url should contain the given value.
        /// </summary>
        /// <param name="urlPart">The URL part the browser is currently displaying.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static Func<IWebDriver, bool> UrlToContain(string urlPart)
        {
            if (urlPart == null) throw new ArgumentNullException(nameof(urlPart));

            return driver => driver.Url.Contains(urlPart);
        }
    }
}