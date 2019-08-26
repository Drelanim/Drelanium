using System;
using Drelanium.Extensions.ISearchContextExtensionMethods;
using Drelanium.Extensions.UriExtensionMethods;
using Drelanium.Extensions.WebDriverWaitExtensionMethods;
using OpenQA.Selenium;
using Serilog.Core;

namespace Drelanium.WebDriver
{
    /// <summary>
    /// Extended implementation of <see cref="INavigation"/>
    /// </summary>
    public class Navigation : INavigation
    {
        /// <summary>
        /// <see cref="Navigation"/>
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Navigation(IWebDriver driver)
        {
            Driver = driver;
            NavigationImplementation = driver.Navigate();
        }

        /// <summary>
        /// <inheritdoc cref="INavigation"/>
        /// </summary>
        private INavigation NavigationImplementation { get; }

        /// <summary>
        /// <inheritdoc cref="IWebDriver"/>
        /// </summary>
        private IWebDriver Driver { get; }

        /// <summary>
        /// <inheritdoc cref="INavigation.Back()"/>
        /// </summary>
        public void Back()
        {
            NavigationImplementation.Back();
        }


        /// <summary>
        /// <inheritdoc></inheritdoc>
        /// </summary>
        public void Forward()
        {
            NavigationImplementation.Forward();
        }


        /// <summary>
        /// <inheritdoc cref="INavigation.GoToUrl(string)"/>
        /// </summary>
        public void GoToUrl(string url)
        {
            NavigationImplementation.GoToUrl(url);
        }


        /// <summary>
        /// <inheritdoc cref="INavigation.GoToUrl(Uri)"/>
        /// </summary>
        public void GoToUrl(Uri url)
        {
            NavigationImplementation.GoToUrl(url);
        }


        /// <summary>
        /// <inheritdoc cref="INavigation.Refresh()"/>
        /// </summary>
        public void Refresh()
        {
            NavigationImplementation.Refresh();
        }


        /// <summary>
        /// <inheritdoc cref="INavigation.Back()"/>
        /// </summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public void Back(Logger logger)
        {
            {
                logger?.Information("Attempting to navigate back");
            }

            Back();

            {
                logger?.Information("Navigated back");
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <inheritdoc cref="Forward()"/>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public void Forward(Logger logger)
        {
            {
                logger?.Information("Attempting to navigate forward");
            }

            Forward();

            {
                logger?.Information("Navigated forward");
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <inheritdoc cref="GoToUrl(string)"/>
        /// <param name="url"></param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public void GoToUrl(string url, Logger logger)
        {
            {
                logger?.Information($"Attempting to navigate to url ({url})");
            }

            GoToUrl(url);

            {
                logger?.Information($"Navigated to url ({url})");
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <inheritdoc cref="GoToUrl(string)"/>
        /// <param name="url"></param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public void GoToUrl(Uri url, Logger logger)
        {
            GoToUrl(url.AbsoluteUri, logger);
        }

        /// <summary>
        ///
        /// </summary>
        /// <inheritdoc cref="Refresh()"/>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public void Refresh(Logger logger)
        {
            {
                logger?.Information($"Refreshing the current page ({Driver.Url})");
            }

            Refresh();

            {
                logger?.Information($"The current page ({Driver.Url}) has been refreshed");
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <inheritdoc cref="GoToUrl(string)"/>
        /// <param name="url">To be added...</param>
        /// <param name="checkHttpResponse">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public void GoToUrl(UriBuilder url, bool checkHttpResponse, Logger logger = null)
        {
            if (checkHttpResponse)
            {
                url.Uri.HttpWebResponse(logger: logger);
            }

            GoToUrl(url.Uri, logger);
        }

        /// <summary>
        ///
        /// </summary>
        /// <inheritdoc cref="GoToUrl(string)"/>
        /// <param name="url">The URL to load.</param>
        /// <param name="loadWithoutCookies">To visit the url without cookies.</param>
        /// <param name="checkHttpResponse">To get a HTTPWebResponse before visit.</param>
        /// <param name="matchingUriPartial">Part of the URL that should match after navigation.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public void GoToUrl(UriBuilder url, bool checkHttpResponse, bool loadWithoutCookies, TimeSpan timeout,
            UriPartial matchingUriPartial, Logger logger = null)
        {
            GoToUrl(url, checkHttpResponse, logger);

            if (loadWithoutCookies)
            {
                Driver.Wait(timeout).UntilPageHasLoadedWithoutCookies(url, matchingUriPartial, logger);
                return;
            }

            Driver.Wait(timeout).UntilPageHasLoaded(url, matchingUriPartial, logger);
        }
    }
}