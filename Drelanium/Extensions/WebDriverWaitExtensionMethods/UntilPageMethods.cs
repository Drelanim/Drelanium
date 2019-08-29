using System;
using Drelanium.Extensions.IWebDriverExtensionMethods;
using Drelanium.WebDriver;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilPageMethods
    {
        /// <summary>
        ///     Waits, until the browser's loaded url partial is matching with the given url partial.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="url">...Description to be added...</param>
        /// <param name="matchingUriPartial">
        ///     One of the <see cref="UriPartial" /> values that specifies the end of the URI portion,
        ///     that should be matching.
        /// </param>
        public static bool UntilPageHasLoaded(this WebDriverWait wait, Uri url, UriPartial matchingUriPartial,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({url.AbsoluteUri}) page to be loaded.");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until page on ({url.AbsoluteUri}) has been successfully loaded";
            var result = wait.Until(driver =>
                driver.Document().URL.GetLeftPart(matchingUriPartial) == url.GetLeftPart(matchingUriPartial)
                && driver.Document().ReadyState == DocumentReadyState.complete);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        /// <summary>
        ///     Waits, until the browser's loaded url partial is matching with the given url partial.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="url">...Description to be added...</param>
        /// <param name="matchingUriPartial">
        ///     One of the <see cref="UriPartial" /> values that specifies the end of the URI portion,
        ///     that should be matching.
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static bool UntilPageHasLoaded(this WebDriverWait wait, UriBuilder url, UriPartial matchingUriPartial,
            Logger logger = null)
        {
            return UntilPageHasLoaded(wait, url.Uri, matchingUriPartial, logger);
        }


        /// <summary>
        ///     Waits, until the browser's loaded url partial is matching with the given url partial without any cookies present.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="url">...Description to be added...</param>
        /// <param name="matchingUriPartial">
        ///     One of the <see cref="UriPartial" /> values that specifies the end of the URI portion,
        ///     that should be matching.
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static bool UntilPageHasLoadedWithoutCookies(this WebDriverWait wait, Uri url,
            UriPartial matchingUriPartial, Logger logger = null)
        {
            logger?.Information($"Waiting for ({url.AbsoluteUri}) page to be loaded without cookies.");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until page on ({url.AbsoluteUri}) has been successfully loaded without cookies";
            wait.Until(driver =>
            {
                driver.Manage().Cookies.DeleteAllCookies();

                if (driver.Document().Domain == url.Host
                    && driver.Document().ReadyState == DocumentReadyState.complete
                    && driver.Manage().Cookies.AllCookies.Count == 0)

                {
                    driver.Navigate().Refresh();
                    return true;
                }

                return false;
            });

            return UntilPageHasLoaded(wait, url, matchingUriPartial);
        }


        /// <summary>
        ///     Waits, until the browser's loaded url partial is matching with the given url partial without any cookies present.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="matchingUriPartial">
        ///     One of the <see cref="UriPartial" /> values that specifies the end of the URI portion,
        ///     that should be matching.
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="url">...Description to be added...</param>
        public static bool UntilPageHasLoadedWithoutCookies(this WebDriverWait wait, UriBuilder url,
            UriPartial matchingUriPartial, Logger logger = null)
        {
            return UntilPageHasLoadedWithoutCookies(wait, url.Uri, matchingUriPartial, logger);
        }
    }
}