using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace Drelanium.Extensions.IWebDriverExtensionMethods
{

    public static class CreateActions
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public static Actions Actions(this IWebDriver driver)
        {

          


            return new Actions(driver);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static void KeyDownAndUp(this IWebDriver driver, string theKey)
        {
            driver
                .Actions()
                .KeyDown(theKey)
                .KeyUp(theKey)
                .Build()
                .Perform();
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static void SendKeys(this IWebDriver driver, string textToSend)
        {
            driver
                .Actions()
                .SendKeys(textToSend)
                .Build()
                .Perform();
        }













    }

}