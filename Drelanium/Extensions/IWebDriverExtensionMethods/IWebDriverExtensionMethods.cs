using System;
using System.Drawing;
using Drelanium.WebDriver;
using OpenQA.Selenium;
using Serilog.Core;

namespace Drelanium.Extensions.IWebDriverExtensionMethods
{
    /// <summary>
    /// Extension methods for <see cref="IWebDriver"/> types.
    ///</summary>
    public static class IWebDriverExtensionMethods
    {
        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Uri Url(this IWebDriver driver)
        {
            return new Uri(driver.Url);
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Options Options(this IWebDriver driver)
        {
            return new Options(driver);
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Navigation Navigation(this IWebDriver driver)
        {
            return new Navigation(driver);
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static TargetLocator Switch(this IWebDriver driver)
        {
            return new TargetLocator(driver);
        }

        /// <summary>
        /// Methods to perform scroll in the browser.
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Scroll Scroll(this IWebDriver driver)
        {
            return new Scroll(driver);
        }

        /// <summary>
        ///To be added..
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Capabilities Capabilities(this IWebDriver driver)
        {
            return new Capabilities(driver);
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Create Create(this IWebDriver driver)
        {
            return new Create(driver);
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Mouse Mouse(this IWebDriver driver)
        {
            return new Mouse(driver);
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Document Document(this IWebDriver driver)
        {
            return new Document(driver);
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static JQuery JQuery(this IWebDriver driver)
        {
            return new JQuery(driver);
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static IWebElement Body(this IWebDriver driver)
        {
            return driver.FindElement(By.TagName("body"));
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="y">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="x">To be added...</param>
        public static void Click(this IWebDriver driver, int x, int y, Logger logger = null)
        {
            driver.Actions().MoveTo(x, y).Click().BuildAndPerform(logger);
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="point">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static void Click(this IWebDriver driver, Point point, Logger logger = null)
        {
            driver.Click(point.X, point.Y, logger);
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static void Quit(this IWebDriver driver, Logger logger = null)
        {
            driver.Quit();
            logger?.Information("Quitting WebDriver.");
        }
    }
}