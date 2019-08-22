using System;
using Drelanium.Extensions.ISearchContextExtensionMethods;
using Drelanium.Extensions.UriExtensionMethods;
using Drelanium.Extensions.WebDriverWaitExtensionMethods;
using OpenQA.Selenium;
using Serilog.Core;

namespace Drelanium.WebDriver
{
    /// <summary>To be added...</summary>
    public class Navigation : INavigation
    {
        /// <summary>To be added...</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Navigation(IWebDriver driver)
        {
            Driver = driver;
            NavigationImplementation = driver.Navigate();
        }

        /// <summary>To be added...</summary>
        private INavigation NavigationImplementation { get; }

        /// <summary>To be added...</summary>
        private IWebDriver Driver { get; }

        /// <summary>To be added...</summary>
        public void Back()
        {
            NavigationImplementation.Back();
        }

        /// <summary>To be added...</summary>
        public void Forward()
        {
            NavigationImplementation.Forward();
        }

        /// <summary>To be added...</summary>
        public void GoToUrl(string url)
        {
            NavigationImplementation.GoToUrl(url);
        }

        /// <summary>To be added...</summary>
        public void GoToUrl(Uri url)
        {
            NavigationImplementation.GoToUrl(url);
        }

        /// <summary>To be added...</summary>
        public void Refresh()
        {
            NavigationImplementation.Refresh();
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void Back(Logger logger = null)
        {
            {
                logger?.Information("Attempting to navigate back");
            }

            Back();

            {
                logger?.Information("Navigated back");
            }
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void Forward(Logger logger = null)
        {
            {
                logger?.Information("Attempting to navigate forward");
            }

            Forward();

            {
                logger?.Information("Navigated forward");
            }
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void GoToUrl(string url, Logger logger = null)
        {
            {
                logger?.Information($"Attempting to navigate to url ({url})");
            }

            GoToUrl(url);

            {
                logger?.Information($"Navigated to url ({url})");
            }
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void GoToUrl(Uri url, Logger logger = null)
        {
            GoToUrl(url.AbsoluteUri, logger);
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void Refresh(Logger logger = null)
        {
            {
                logger?.Information($"Refreshing the current page ({Driver.Url})");
            }

            Refresh();

            {
                logger?.Information($"The current page ({Driver.Url}) has been refreshed");
            }
        }

        /// <summary>To be added...</summary>
        /// <param name="url">To be added...</param>
        /// <param name="checkHttpResponse">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void GoToUrl(UriBuilder url, bool checkHttpResponse, Logger logger = null)
        {
            if (checkHttpResponse)
            {
                url.Uri.HttpWebResponse(logger: logger);
            }

            GoToUrl(url.Uri, logger);
        }

        /// <summary>To be added...</summary>
        /// <param name="url">The URL to load.</param>
        /// <param name="loadWithoutCookies">To visit the url without cookies.</param>
        /// <param name="checkHttpResponse">To get a HTTPWebResponse before visit.</param>
        /// <param name="matchingUriPartial">Part of the URL that should match after navigation.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
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