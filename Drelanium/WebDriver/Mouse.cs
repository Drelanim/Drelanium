using System;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class Mouse
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Mouse(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>
        private IWebDriver Driver { get; }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="y">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="x">...Description to be added...</param>
        public void MoveBy(int x, int y, Logger logger = null)
        {
            Driver.Actions().MoveByOffset(x, y).BuildAndPerform(logger);
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="y">...Description to be added...</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="x">...Description to be added...</param>
        public void MoveByAndWaitUntilCondition<TResult>(int x, int y, WebDriverWait wait,
            Func<IWebDriver, TResult> condition,
            Logger logger = null)
        {
            Driver.Actions().MoveByOffset(x, y).BuildAndPerform(wait, condition, logger);
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="y">...Description to be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="x">...Description to be added...</param>
        public void MoveTo(int x, int y, Logger logger = null)
        {
            Driver.Actions().MoveTo(x, y).BuildAndPerform(logger);
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="point">...Description to be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void MoveTo(Point point, Logger logger = null)
        {
            MoveTo(point.X, point.Y, logger);
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="y">...Description to be added...</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="x">...Description to be added...</param>
        public void MoveToAndWaitUntilCondition<TResult>(int x, int y, WebDriverWait wait,
            Func<IWebDriver, TResult> condition,
            Logger logger = null)
        {
            Driver.Actions().MoveTo(x, y).BuildAndPerform(wait, condition, logger);
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="point">...Description to be added...</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        public void MoveToAndWaitUntilCondition<TResult>(Point point, WebDriverWait wait,
            Func<IWebDriver, TResult> condition,
            Logger logger = null)
        {
            MoveToAndWaitUntilCondition(point.X, point.Y, wait, condition, logger);
        }
    }
}