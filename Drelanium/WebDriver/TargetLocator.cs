using System.ComponentModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium
{
    /// <summary>
    ///     Extended implementation of <see cref="ITargetLocator" />
    /// </summary>
    public class TargetLocator : ITargetLocator
    {
        /// <summary>
        ///     <inheritdoc cref="TargetLocator" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public TargetLocator(IWebDriver driver)
        {
            Driver = driver;
            TargetLocatorImplementation = driver.SwitchTo();
        }

        /// <summary>
        ///     <inheritdoc cref="ITargetLocator" />
        /// </summary>
        private ITargetLocator TargetLocatorImplementation { get; }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>
        private IWebDriver Driver { get; }


        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.Frame(int)" />
        /// </summary>
        public IWebDriver Frame(int frameIndex)
        {
            return TargetLocatorImplementation.Frame(frameIndex);
        }


        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.Frame(string)" />
        /// </summary>
        public IWebDriver Frame(string frameName)
        {
            return TargetLocatorImplementation.Frame(frameName);
        }


        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.Frame(IWebElement)" />
        /// </summary>
        public IWebDriver Frame(IWebElement frameElement)
        {
            return TargetLocatorImplementation.Frame(frameElement);
        }


        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.ParentFrame()" />
        /// </summary>
        public IWebDriver ParentFrame()
        {
            return TargetLocatorImplementation.ParentFrame();
        }


        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.Window(string)" />
        /// </summary>
        public IWebDriver Window(string windowName)
        {
            return TargetLocatorImplementation.Window(windowName);
        }


        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.DefaultContent()" />
        /// </summary>
        public IWebDriver DefaultContent()
        {
            return TargetLocatorImplementation.DefaultContent();
        }


        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.ActiveElement()" />
        /// </summary>
        public IWebElement ActiveElement()
        {
            return TargetLocatorImplementation.ActiveElement();
        }


        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.Alert()" />
        /// </summary>
        public IAlert Alert()
        {
            return TargetLocatorImplementation.Alert();
        }

        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.ActiveElement()" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebElement ActiveElement(Logger logger)
        {
            logger?.Information("Switching to Active element.");

            return ActiveElement();
        }

        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.Alert()" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IAlert Alert(Logger logger)
        {
            logger?.Information("Switching to Alert.");

            return Alert();
        }

        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.DefaultContent()" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebDriver DefaultContent(Logger logger)
        {
            logger?.Information("Switching to default content.");

            return DefaultContent();
        }


        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebDriver FirstWindow(Logger logger = null)
        {
            logger?.Information("Switching to the 1st window.");

            return Window(Driver.WindowHandles[0]);
        }

        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.Frame(int)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="frameIndex">...Description to be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Frame(int frameIndex, Logger logger)
        {
            logger?.Information($"Switching to Frame({frameIndex}).");

            return Frame(frameIndex);
        }

        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.Frame(string)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="frameName">...Description to be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Frame(string frameName, Logger logger)
        {
            logger?.Information($"Switching to Frame({frameName}).");

            return Frame(frameName);
        }

        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.Frame(IWebElement)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="frameElement">...Description to be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Frame(IWebElement frameElement, Logger logger)
        {
            logger?.Information($"Switching to Frame({frameElement}).");

            return Frame(frameElement);
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebDriver LastWindow(Logger logger = null)
        {
            logger?.Information("Switching to the last window.");

            return Window(Driver.WindowHandles[Driver.WindowHandles.Count - 1]);
        }

        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.ParentFrame()" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebDriver ParentFrame(Logger logger)
        {
            logger?.Information("Switching to ParentFrame.");

            return ParentFrame();
        }

        /// <summary>
        ///     <inheritdoc cref="ITargetLocator.Window(string)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="windowName">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebDriver Window(string windowName, Logger logger)
        {
            logger?.Information($"Switching to Window({windowName}).");

            return Window(windowName);
        }


        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="indexOfWindow">...Description to be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebDriver Window(int indexOfWindow, Logger logger = null)
        {
            var numberOfWindow = indexOfWindow + 1;

            if (indexOfWindow < 0) throw new InvalidEnumArgumentException();

            while (numberOfWindow > Driver.WindowHandles.Count) Driver.ExecuteJavaScript("window.open();.");

            return Window(Driver.WindowHandles[indexOfWindow], logger);
        }
    }
}