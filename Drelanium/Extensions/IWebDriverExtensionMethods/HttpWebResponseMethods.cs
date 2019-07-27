using System;
using System.Net;
using Drelanium.Extensions.UriExtensionMethods;
using OpenQA.Selenium;


namespace Drelanium.Extensions.IWebDriverExtensionMethods
{

    public static class HttpWebResponseMethods
    {

        public static HttpWebResponse HttpWebResponse(this IWebDriver driver, Uri url)
        {
            return url.HttpWebResponse();
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static HttpWebResponse HttpWebResponse(this IWebDriver driver)
        {
            return driver.Url().HttpWebResponse();
        }

    }

}