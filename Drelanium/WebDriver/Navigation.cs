using System;
using Drelanium.Extensions.ISearchContextExtensionMethods;
using Drelanium.Extensions.UriExtensionMethods;
using Drelanium.Extensions.WebDriverWaitExtensionMethods;
using OpenQA.Selenium;


namespace Drelanium.WebDriver
{

    public class Navigation : INavigation
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public Navigation(IWebDriver driver)
        {
            Driver = driver;
            NavigationImplementation = driver.Navigate();
        }

        private INavigation NavigationImplementation { get; }
        private IWebDriver Driver { get; }

        public void Back()
        {
            NavigationImplementation.Back();
        }

        public void Forward()
        {
            NavigationImplementation.Forward();
        }

        public void GoToUrl(string url)
        {
            NavigationImplementation.GoToUrl(url);
        }

        public void GoToUrl(Uri url)
        {
            NavigationImplementation.GoToUrl(url);
        }

        public void Refresh()
        {
            NavigationImplementation.Refresh();
        }

        /// <param name="url">The URL to load.</param>
        /// <param name="loadWithoutCookies">To visit the url without cookies.</param>
        /// <param name="getHttpWebResponseFirst">To get a HTTPWebResponse before visit.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        public void GoToUrl(string url, TimeSpan timeout, bool getHttpWebResponseFirst = false, bool loadWithoutCookies = false)
        {
            GoToUrl(url);

            if (getHttpWebResponseFirst)
            {
                new Uri(url).HttpWebResponse();
            }

            if (loadWithoutCookies)
            {
                Driver.Wait(timeout).UntilPageHasLoadedWithoutCookies(url);
                return;
            }

            Driver.Wait(timeout).UntilPageHasLoaded(url);
        }

        /// <param name="url">The URL to load.</param>
        /// <param name="loadWithoutCookies">To visit the url without cookies.</param>
        /// <param name="getHttpWebResponseFirst">To get a HTTPWebResponse before visit.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        public void GoToUrl(Uri url, TimeSpan timeout, bool getHttpWebResponseFirst = false, bool loadWithoutCookies = false)
        {
            GoToUrl(url.AbsoluteUri, timeout, getHttpWebResponseFirst, loadWithoutCookies);
        }

        /// <param name="url">The URL to load.</param>
        /// <param name="loadWithoutCookies">To visit the url without cookies.</param>
        /// <param name="getHttpWebResponseFirst">To get a HTTPWebResponse before visit.</param>
        public void GoToUrl(string url, bool getHttpWebResponseFirst = false, bool loadWithoutCookies = false)
        {
            GoToUrl(url, Driver.Manage().Timeouts().PageLoad, getHttpWebResponseFirst, loadWithoutCookies);
        }

        /// <param name="url">The URL to load.</param>
        /// <param name="loadWithoutCookies">To visit the url without cookies.</param>
        /// <param name="getHttpWebResponseFirst">To get a HTTPWebResponse before visit.</param>
        public void GoToUrl(Uri url, bool getHttpWebResponseFirst = false, bool loadWithoutCookies = false)
        {
            GoToUrl(url.AbsoluteUri, getHttpWebResponseFirst, loadWithoutCookies);
        }

    }

}