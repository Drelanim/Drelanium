using System;
using System.Net;
using Drelanium.Extensions.UriExtensionMethods;
using OpenQA.Selenium;


namespace Drelanium.Extensions.IWebDriverExtensionMethods
{

    public static class HttpWebRequestMethods
    {

        /// <param name="url">The URL to load.</param>
        /// <param name="driver">The used WebDriver instance.</param>
        public static HttpWebRequest HttpWebRequest(this IWebDriver driver, Uri url)
        {
            return url.HttpWebRequest();
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static HttpWebRequest HttpWebRequest(this IWebDriver driver)
        {
            return driver.Url().HttpWebRequest();
        }

    }

}