using System;
using Drelanium.WebDriver;
using OpenQA.Selenium;


namespace Drelanium.Extensions.IWebDriverExtensionMethods
{

    public static class IWebDriverExtensionMethods
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public static Uri Url(this IWebDriver driver)
        {
            return new Uri(driver.Url);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static Options Options(this IWebDriver driver)
        {
            return new Options(driver);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static Navigation Navigation(this IWebDriver driver)
        {
            return new Navigation(driver);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static TargetLocator Switch(this IWebDriver driver)
        {
            return new TargetLocator(driver);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static Scroll Scroll(this IWebDriver driver)
        {
            return new Scroll(driver);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static Capabilities Capabilities(this IWebDriver driver)
        {
            return new Capabilities(driver);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static Create Create(this IWebDriver driver)
        {
            return new Create(driver);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static Document Document(this IWebDriver driver)
        {
            return new Document(driver);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static IWebElement Body(this IWebDriver driver)
        {
            return driver.FindElement(By.TagName("body"));
        }

    }

}