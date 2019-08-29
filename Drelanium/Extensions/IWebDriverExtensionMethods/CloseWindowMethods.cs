using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium.Extensions.IWebDriverExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="IWebDriver" /> types.
    /// </summary>
    public static class CloseWindowMethods
    {
        /// <summary>
        ///     To be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static IWebDriver CloseFirstWindow(this IWebDriver driver, Logger logger = null)
        {
            logger?.Information("Closing the first browser window tab.");

            return driver.CloseWindow(0);
        }

        /// <summary>
        ///     To be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static IWebDriver CloseLastWindow(this IWebDriver driver, Logger logger = null)
        {
            logger?.Information("Closing the last browser window tab.");

            return driver.CloseWindow(driver.WindowHandles.Count - 1);
        }

        /// <summary>
        ///     To be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="indexOfWindow">Index of the window that should be closed.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static IWebDriver CloseWindow(this IWebDriver driver, int indexOfWindow, Logger logger = null)
        {
            logger?.Information($"Closing browser window tab #{indexOfWindow}.");

            var currentWindowHandle = driver.CurrentWindowHandle;

            driver.Switch().Window(indexOfWindow).Close();
            return driver.Switch().Window(currentWindowHandle);
        }
    }
}