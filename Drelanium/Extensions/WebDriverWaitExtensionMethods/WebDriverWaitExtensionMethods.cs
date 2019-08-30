using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;

#pragma warning disable 1580
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved


namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public static class WebDriverWaitExtensionMethods
    {
        /// <summary>
        ///     <inheritdoc cref="WebDriverWait.Until()" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{IWebDriver, IWebElement}" />, that defines the condition until the browser
        ///     must wait.
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static TResult Until<TResult>(this WebDriverWait wait, Func<IWebDriver, TResult> condition,
            Logger logger)

        {
            logger?.Information("Commanded browser to wait for certain condition.");

            var result = wait.Until(condition);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }
    }
}