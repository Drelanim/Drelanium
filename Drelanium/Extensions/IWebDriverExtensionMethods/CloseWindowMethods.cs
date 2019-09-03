using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebDriver" /> types.
    /// </summary>
    public static class CloseWindowMethods
    {
        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static IWebDriver CloseFirstWindow([NotNull] this IWebDriver driver, [CanBeNull] Logger logger = null)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            logger?.Information("Closing the first browser window tab.");

            return driver.CloseWindow(0);
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
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static IWebDriver CloseLastWindow([NotNull] this IWebDriver driver, [CanBeNull] Logger logger = null)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            logger?.Information("Closing the last browser window tab.");

            return driver.CloseWindow(driver.WindowHandles.Count - 1);
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
        /// <param name="indexOfWindow">Index of the window that should be closed.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static IWebDriver CloseWindow([NotNull] this IWebDriver driver, int indexOfWindow,
            [CanBeNull] Logger logger = null)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            logger?.Information($"Closing browser window tab #{indexOfWindow}.");

            var currentWindowHandle = driver.CurrentWindowHandle;

            driver.Switch().Window(indexOfWindow).Close();
            return driver.Switch().Window(currentWindowHandle);
        }
    }
}