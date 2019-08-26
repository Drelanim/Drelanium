using System.ComponentModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using Serilog.Core;

namespace Drelanium.WebDriver
{
    /// <summary>
    ///To be added...</summary>
    public class TargetLocator : ITargetLocator
    {
        /// <summary>
        ///To be added...</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public TargetLocator(IWebDriver driver)
        {
            Driver = driver;
            TargetLocatorImplementation = driver.SwitchTo();
        }


        /// <inheritdoc cref="ITargetLocator"/>
        private ITargetLocator TargetLocatorImplementation { get; }


        /// <inheritdoc cref="IWebDriver"/>
        private IWebDriver Driver { get; }


        /// <inheritdoc></inheritdoc>
        public IWebDriver Frame(int frameIndex)
        {
            return TargetLocatorImplementation.Frame(frameIndex);
        }

        /// <inheritdoc></inheritdoc>
        public IWebDriver Frame(string frameName)
        {
            return TargetLocatorImplementation.Frame(frameName);
        }


        /// <inheritdoc></inheritdoc>
        public IWebDriver Frame(IWebElement frameElement)
        {
            return TargetLocatorImplementation.Frame(frameElement);
        }

        /// <inheritdoc></inheritdoc>
        public IWebDriver ParentFrame()
        {
            return TargetLocatorImplementation.ParentFrame();
        }

        /// <inheritdoc></inheritdoc>
        public IWebDriver Window(string windowName)
        {
            return TargetLocatorImplementation.Window(windowName);
        }

        /// <inheritdoc></inheritdoc>
        public IWebDriver DefaultContent()
        {
            return TargetLocatorImplementation.DefaultContent();
        }


        /// <inheritdoc></inheritdoc>
        public IWebElement ActiveElement()
        {
            return TargetLocatorImplementation.ActiveElement();
        }


        /// <inheritdoc></inheritdoc>
        public IAlert Alert()
        {
            return TargetLocatorImplementation.Alert();
        }


        /// <inheritdoc cref="Frame(int)"/>
        ///  <param name="frameIndex"></param>
        ///  <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Frame(int frameIndex, Logger logger)
        {
            {
                logger?.Information($"Switching to Frame({frameIndex})");
            }

            return Frame(frameIndex);
        }


        /// <inheritdoc cref="Frame(string)"/>
        ///  <param name="frameName"></param>
        ///  <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Frame(string frameName, Logger logger)
        {
            {
                logger?.Information($"Switching to Frame({frameName})");
            }

            return Frame(frameName);
        }


        /// <inheritdoc cref="Frame(IWebElement)"/>
        ///  <param name="frameElement"></param>
        ///  <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Frame(IWebElement frameElement, Logger logger)
        {
            {
                logger?.Information($"Switching to Frame({frameElement})");
            }

            return Frame(frameElement);
        }


        /// <inheritdoc cref="ParentFrame()"/>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public IWebDriver ParentFrame(Logger logger)
        {
            {
                logger?.Information("Switching to ParentFrame");
            }

            return ParentFrame();
        }


        /// <inheritdoc cref="Window(string)"/>
        /// <param name="windowName"></param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public IWebDriver Window(string windowName, Logger logger)
        {
            {
                logger?.Information($"Switching to Window({windowName})");
            }

            return Window(windowName);
        }


        /// <inheritdoc cref="DefaultContent()"/>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public IWebDriver DefaultContent(Logger logger)
        {
            logger?.Information("Switching to default content");

            return DefaultContent();
        }


        /// <inheritdoc cref="ActiveElement()"/>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public IWebElement ActiveElement(Logger logger)
        {
            logger?.Information("Switching to Active element");

            return ActiveElement();
        }


        /// <inheritdoc cref="Alert()"/>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public IAlert Alert(Logger logger)
        {
            logger?.Information("Switching to Alert");

            return Alert();
        }


        ///  <summary>
        /// To be added...</summary>
        ///  <param name="indexOfWindow"></param>
        ///  <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Window(int indexOfWindow, Logger logger = null)
        {
            var numberOfWindow = indexOfWindow + 1;

            if (indexOfWindow < 0) throw new InvalidEnumArgumentException();

            while (numberOfWindow > Driver.WindowHandles.Count) Driver.ExecuteJavaScript("window.open();");

            return Window(Driver.WindowHandles[indexOfWindow], logger);
        }


        /// <summary>
        ///To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public IWebDriver FirstWindow(Logger logger = null)
        {
            {
                logger?.Information("Switching to the 1st window");
            }

            return Window(Driver.WindowHandles[0]);
        }

        /// <summary>
        ///To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public IWebDriver LastWindow(Logger logger = null)
        {
            {
                logger?.Information("Switching to the last window");
            }

            return Window(Driver.WindowHandles[Driver.WindowHandles.Count - 1]);
        }
    }
}