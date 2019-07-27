using System.ComponentModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;


namespace Drelanium.WebDriver
{

    public class TargetLocator : ITargetLocator
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public TargetLocator(IWebDriver driver)
        {
            Driver = driver;
            TargetLocatorImplementation = driver.SwitchTo();
        }

        private ITargetLocator TargetLocatorImplementation { get; }
        private IWebDriver Driver { get; }

        public IWebDriver Frame(int frameIndex)
        {
            return TargetLocatorImplementation.Frame(frameIndex);
        }

        public IWebDriver Frame(string frameName)
        {
            return TargetLocatorImplementation.Frame(frameName);
        }

        public IWebDriver Frame(IWebElement frameElement)
        {
            return TargetLocatorImplementation.Frame(frameElement);
        }

        public IWebDriver ParentFrame()
        {
            return TargetLocatorImplementation.ParentFrame();
        }

        public IWebDriver Window(string windowName)
        {
            return TargetLocatorImplementation.Window(windowName);
        }

        public IWebDriver DefaultContent()
        {
            return TargetLocatorImplementation.DefaultContent();
        }

        public IWebElement ActiveElement()
        {
            return TargetLocatorImplementation.ActiveElement();
        }

        public IAlert Alert()
        {
            return TargetLocatorImplementation.Alert();
        }

        public IWebDriver Window(int indexOfWindow)
        {
            var numberOfWindow = indexOfWindow + 1;

            if (indexOfWindow < 0) throw new InvalidEnumArgumentException();

            while (numberOfWindow > Driver.WindowHandles.Count) Driver.ExecuteJavaScript("window.open();");

            return Driver.SwitchTo().Window(Driver.WindowHandles[indexOfWindow]);
        }

        public IWebDriver FirstWindow()
        {
            return Driver.SwitchTo().Window(Driver.WindowHandles[0]);
        }

        public IWebDriver LastWindow()
        {
            return Driver.SwitchTo().Window(Driver.WindowHandles[Driver.WindowHandles.Count - 1]);
        }

    }

}