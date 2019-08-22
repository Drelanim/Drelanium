using Drelanium.WebDriver;
using OpenQA.Selenium;
using Serilog.Core;


namespace Drelanium.Extensions.IWebDriverExtensionMethods
{

    /// <summary>To be added...</summary>
    public static class CreateActions
    {

        /// <summary>To be added...</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static ExtendedActions Actions(this IWebDriver driver)
        {
            return new ExtendedActions(driver);
        }

        /// <summary>To be added...</summary>
        /// <param name="theKey">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static void KeyDownAndUp(this IWebDriver driver, string theKey, Logger logger = null)
        {
            logger?.Information($"Executing a KeyDown and then a KeyUp action using the {theKey}.");

            driver
                .Actions()
                .KeyDown(theKey)
                .KeyUp(theKey)
                .BuildAndPerform(logger);
        }

        /// <summary>To be added...</summary>
        /// <param name="textToSend">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static void SendKeys(this IWebDriver driver, string textToSend, Logger logger = null)
        {
            logger?.Information($"Executing a SendKeys action with text {textToSend}");

            driver
                .Actions()
                .SendKeys(textToSend)
                .BuildAndPerform(logger);
        }

    }

}