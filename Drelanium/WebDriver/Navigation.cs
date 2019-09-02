using System;
using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;


// ReSharper disable CommentTypo

namespace Drelanium
{
    /// <summary>
    ///     Extended implementation of <see cref="INavigation" />
    /// </summary>
    public class Navigation : INavigation
    {
        /// <summary>
        ///     <inheritdoc cref="Navigation" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Navigation(IWebDriver driver)
        {
            Driver = driver;
            NavigationImplementation = driver.Navigate();
        }

        /// <summary>
        ///     <inheritdoc cref="INavigation" />
        /// </summary>
        private INavigation NavigationImplementation { get; }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>
        private IWebDriver Driver { get; }

        /// <summary>
        ///     <inheritdoc cref="INavigation.Back()" />
        /// </summary>
        public void Back()
        {
            NavigationImplementation.Back();
        }


        /// <summary>
        ///     <inheritdoc cref="INavigation.Forward()" />
        /// </summary>
        public void Forward()
        {
            NavigationImplementation.Forward();
        }


        /// <summary>
        ///     <inheritdoc cref="INavigation.GoToUrl(string)" />
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void GoToUrl(string url)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));

            NavigationImplementation.GoToUrl(url);
        }


        /// <summary>
        ///     <inheritdoc cref="INavigation.GoToUrl(Uri)" />
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void GoToUrl(Uri url)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));

            NavigationImplementation.GoToUrl(url);
        }


        /// <summary>
        ///     <inheritdoc cref="INavigation.Refresh()" />
        /// </summary>
        public void Refresh()
        {
            NavigationImplementation.Refresh();
        }


        /// <summary>
        ///     <inheritdoc cref="INavigation.Back()" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public void Back(Logger logger)
        {
            logger?.Information("Attempting to navigate back.");

            Back();

            logger?.Information("Navigated back.");
        }


        /// <summary>
        ///     <inheritdoc cref="INavigation.Forward()" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public void Forward(Logger logger)
        {
            logger?.Information("Attempting to navigate forward.");

            Forward();

            logger?.Information("Navigated forward.");
        }


        /// <summary>
        ///     <inheritdoc cref="INavigation.GoToUrl(string)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="url">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public void GoToUrl(string url, Logger logger)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));

            logger?.Information($"Attempting to navigate to url ({url}).");

            GoToUrl(url);

            logger?.Information($"Navigated to url ({url}).");
        }


        /// <summary>
        ///     <inheritdoc cref="INavigation.GoToUrl(string)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="url">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public void GoToUrl(Uri url, Logger logger)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));

            GoToUrl(url.AbsoluteUri, logger);
        }


        /// <summary>
        ///     <inheritdoc cref="INavigation.GoToUrl(string)" />
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="url">
        ///     <inheritdoc cref="INavigation.GoToUrl(string)" />
        /// </param>
        /// <param name="checkHttpResponse">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public void GoToUrl(Uri url, bool checkHttpResponse, Logger logger = null)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));

            if (checkHttpResponse)
            {
                url.HttpWebResponse(logger: logger);
            }

            GoToUrl(url, logger);
        }


        /// <summary>
        ///     <inheritdoc cref="INavigation.GoToUrl(string)" />
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="url">The URL to load.</param>
        /// <param name="loadWithoutCookies">To visit the url without cookies.</param>
        /// <param name="checkHttpResponse">To get a HTTPWebResponse before visit.</param>
        /// <param name="timeoutInSeconds">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="urlCondition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public void GoToUrl(Uri url, bool checkHttpResponse, bool loadWithoutCookies, double timeoutInSeconds,
            Func<Uri, bool> urlCondition, Logger logger = null)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));
            if (urlCondition == null) throw new ArgumentNullException(nameof(urlCondition));

            GoToUrl(url, checkHttpResponse, logger);

            if (loadWithoutCookies)
            {
                Driver.Wait(timeoutInSeconds).UntilPageHasLoadedWithoutCookies(urlCondition);
            }

            Driver.Wait(timeoutInSeconds).UntilPageHasLoaded(urlCondition);
        }


        /// <summary>
        ///     <inheritdoc cref="INavigation.GoToUrl(string)" />
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="url">The URL to load.</param>
        /// <param name="loadWithoutCookies">To visit the url without cookies.</param>
        /// <param name="checkHttpResponse">To get a HTTPWebResponse before visit.</param>
        /// <param name="timeoutInSeconds">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="urlCondition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public void GoToUrl(Uri url, bool checkHttpResponse, bool loadWithoutCookies, double timeoutInSeconds,
            Func<string, bool> urlCondition, Logger logger = null)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));
            if (urlCondition == null) throw new ArgumentNullException(nameof(urlCondition));

            GoToUrl(url, checkHttpResponse, loadWithoutCookies, timeoutInSeconds, uri => urlCondition(uri.AbsoluteUri),
                logger);
        }


        /// <summary>
        ///     <inheritdoc cref="INavigation.Refresh()" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public void Refresh(Logger logger)
        {
            logger?.Information($"Refreshing the current page ({Driver.Url}).");

            Refresh();

            logger?.Information($"The current page ({Driver.Url}) has been refreshed.");
        }
    }
}