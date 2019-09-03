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
    public static class CreateActions
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static ExtendedActions Actions([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new ExtendedActions(driver);
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="theKey">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static void KeyDownAndUp([NotNull] this IWebDriver driver, [NotNull] string theKey,
            [CanBeNull] Logger logger = null)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (theKey == null) throw new ArgumentNullException(nameof(theKey));

            logger?.Information($"Executing a KeyDown and then a KeyUp action using the {theKey}.");

            driver
                .Actions()
                .KeyDown(theKey)
                .KeyUp(theKey)
                .BuildAndPerform(logger);
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="textToSend">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static void SendKeys([NotNull] this IWebDriver driver, [NotNull] string textToSend,
            [CanBeNull] Logger logger = null)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (textToSend == null) throw new ArgumentNullException(nameof(textToSend));

            logger?.Information($"Executing a SendKeys action with text {textToSend}.");

            driver
                .Actions()
                .SendKeys(textToSend)
                .BuildAndPerform(logger);
        }
    }
}