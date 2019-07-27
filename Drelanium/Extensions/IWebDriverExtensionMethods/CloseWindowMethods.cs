using OpenQA.Selenium;


namespace Drelanium.Extensions.IWebDriverExtensionMethods
{

    public static class CloseWindowMethods
    {

        /// <param name="indexOfWindow">Index of the window that should be closed.</param>
        /// <param name="driver">The used WebDriver instance.</param>
        public static IWebDriver CloseWindow(this IWebDriver driver, int indexOfWindow)
        {
            ISearchContext dd = driver;

            var currentWindowHandle = driver.CurrentWindowHandle;

            driver.Switch().Window(indexOfWindow).Close();
            return driver.Switch().Window(currentWindowHandle);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static IWebDriver CloseFirstWindow(this IWebDriver driver)
        {
            return driver.CloseWindow(0);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static IWebDriver CloseLastWindow(this IWebDriver driver)
        {
            return driver.CloseWindow(driver.WindowHandles.Count - 1);
        }

    }

}