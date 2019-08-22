using System.ComponentModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using Serilog.Core;


namespace Drelanium.WebDriver
{

    /// <summary>To be added...</summary>
    public class TargetLocator : ITargetLocator
    {

        /// <summary>To be added...</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public TargetLocator(IWebDriver driver)
        {
            Driver = driver;
            TargetLocatorImplementation = driver.SwitchTo();
        }

        /// <summary>To be added...</summary>
        private ITargetLocator TargetLocatorImplementation { get; }

        /// <summary>To be added...</summary>
        private IWebDriver Driver { get; }

        /// <summary>To be added...</summary>
        public IWebDriver Frame(int frameIndex)
        {
            return TargetLocatorImplementation.Frame(frameIndex);
        }

        /// <summary>To be added...</summary>
        public IWebDriver Frame(string frameName)
        {
            return TargetLocatorImplementation.Frame(frameName);
        }

        /// <summary>To be added...</summary>
        public IWebDriver Frame(IWebElement frameElement)
        {
            return TargetLocatorImplementation.Frame(frameElement);
        }

        /// <summary>To be added...</summary>
        public IWebDriver ParentFrame()
        {
            return TargetLocatorImplementation.ParentFrame();
        }

        /// <summary>To be added...</summary>
        public IWebDriver Window(string windowName)
        {
            return TargetLocatorImplementation.Window(windowName);
        }

        /// <summary>To be added...</summary>
        public IWebDriver DefaultContent()
        {
            return TargetLocatorImplementation.DefaultContent();
        }

        /// <summary>To be added...</summary>
        public IWebElement ActiveElement()
        {
            return TargetLocatorImplementation.ActiveElement();
        }

        /// <summary>To be added...</summary>
        public IAlert Alert()
        {
            return TargetLocatorImplementation.Alert();
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Frame(int frameIndex, Logger logger = null)
        {
            {
                logger?.Information($"Switching to Frame({frameIndex})");
            }

            return Frame(frameIndex);
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Frame(string frameName, Logger logger = null)
        {
            {
                logger?.Information($"Switching to Frame({frameName})");
            }

            return Frame(frameName);
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Frame(IWebElement frameElement, Logger logger = null)
        {
            {
                logger?.Information($"Switching to Frame({frameElement})");
            }

            return Frame(frameElement);
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver ParentFrame(Logger logger = null)
        {
            {
                logger?.Information("Switching to ParentFrame");
            }

            return ParentFrame();
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Window(string windowName, Logger logger = null)
        {
            {
                logger?.Information($"Switching to Window({windowName})");
            }

            return Window(windowName);
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver DefaultContent(Logger logger = null)
        {
            logger?.Information("Switching to default content");

            return DefaultContent();
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebElement ActiveElement(Logger logger = null)
        {
            logger?.Information("Switching to Active element");

            return ActiveElement();
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IAlert Alert(Logger logger = null)
        {
            logger?.Information("Switching to Alert");

            return Alert();
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Window(int indexOfWindow, Logger logger = null)
        {
            var numberOfWindow = indexOfWindow + 1;

            if (indexOfWindow < 0) throw new InvalidEnumArgumentException();

            while (numberOfWindow > Driver.WindowHandles.Count) Driver.ExecuteJavaScript("window.open();");

            return Window(Driver.WindowHandles[indexOfWindow], logger);
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver FirstWindow(Logger logger = null)
        {
            {
                logger?.Information("Switching to the 1st window");
            }

            return Window(Driver.WindowHandles[0]);
        }

        /// <summary>To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver LastWindow(Logger logger = null)
        {
            {
                logger?.Information("Switching to the last window");
            }

            return Window(Driver.WindowHandles[Driver.WindowHandles.Count - 1]);
        }

    }

}