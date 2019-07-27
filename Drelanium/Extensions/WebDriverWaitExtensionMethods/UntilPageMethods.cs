using System;
using Drelanium.Extensions.IWebDriverExtensionMethods;
using OpenQA.Selenium.Support.UI;


namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{

    public static class UntilPageMethods
    {

        public static bool UntilPageHasLoaded(this WebDriverWait wait, string url)
        {
            wait.Message += $"Waited until page on ({url}) has been successfully loaded";
            return wait.Until(driver =>
            {
                return driver.Document().URL.GetLeftPart(UriPartial.Query) == new Uri(url).GetLeftPart(UriPartial.Query)
                       && driver.Document().ReadyState == DocumentReadyState.complete;
            });
        }

        public static bool UntilPageHasLoaded(this WebDriverWait wait, Uri url)
        {
            return UntilPageHasLoaded(wait, url.AbsoluteUri);
        }

        public static bool UntilPageHasLoadedWithoutCookies(this WebDriverWait wait, string url)
        {
            wait.Message += $"Waited until page on ({url}) has been successfully loaded without cookies";
            wait.Until(driver =>
            {
                driver.Manage().Cookies.DeleteAllCookies();

                if (driver.Document().Domain == new Uri(url).Host
                    && driver.Document().ReadyState == DocumentReadyState.complete
                    && driver.Manage().Cookies.AllCookies.Count == 0)

                {
                    driver.Navigate().Refresh();
                    return true;
                }

                return false;
            });

            return UntilPageHasLoaded(wait, url);
        }

        public static bool UntilPageHasLoadedWithoutCookies(this WebDriverWait wait, Uri url)
        {
            return UntilPageHasLoadedWithoutCookies(wait, url.AbsoluteUri);
        }

    }

}