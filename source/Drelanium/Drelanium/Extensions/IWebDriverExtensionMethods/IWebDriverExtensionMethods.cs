using System;
using System.Drawing;
using JetBrains.Annotations;
using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebDriver" /> types.
    /// </summary>
    public static class IWebDriverExtensionMethods
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static IWebElement Body([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return driver.FindElement(By.TagName("body"));
        }

        /// <summary>
        ///     Extended implementation of <see cref="ICapabilities" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Capabilities Capabilities([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new Capabilities(driver);
        }

        /// <summary>
        ///     Moves the cursor to a given x-y point and performs a click.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="y">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="x">...Description to be added...</param>
        public static void Click([NotNull] this IWebDriver driver, int x, int y, [CanBeNull] Logger logger = null)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            driver.Actions().MoveTo(x, y).Click().BuildAndPerform(logger);
        }

        /// <summary>
        ///     Moves the cursor to a given point and performs a click.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="point">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static void Click([NotNull] this IWebDriver driver, Point point, [CanBeNull] Logger logger = null)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            driver.Click(point.X, point.Y, logger);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Create Create([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new Create(driver);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Document Document([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new Document(driver);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static JQuery JQuery([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new JQuery(driver);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Mouse Mouse([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new Mouse(driver);
        }

        /// <summary>
        ///     Extended implementation of <see cref="INavigation" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Navigation Navigation([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new Navigation(driver);
        }

        /// <summary>
        ///     Extended implementation of <see cref="IOptions" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Options Options([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new Options(driver);
        }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver.Quit()" /> Logs the action.
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static void Quit([NotNull] this IWebDriver driver, [CanBeNull] Logger logger)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            driver.Quit();
            logger?.Information("Quitting WebDriver.");
        }

        /// <summary>
        ///     Methods to perform scroll in the browser.
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Scroll Scroll([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new Scroll(driver);
        }

        /// <summary>
        ///     Extended implementation of <see cref="ITargetLocator" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static TargetLocator Switch([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new TargetLocator(driver);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Uri Url([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new Uri(driver.Url);
        }
    }
}