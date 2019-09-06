using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

// ReSharper disable InconsistentNaming

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IOptions" /> types.
    /// </summary>
    public static class IOptionsExtensionMethods
    {
        /// <summary>
        ///     <see cref="CookieJar" />
        /// </summary>
        /// <param name="options">The <see cref="IOptions" /> instance, that  allows the user to set options on the browser.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static CookieJar Cookies([NotNull] this IOptions options, [NotNull] IWebDriver driver)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new CookieJar(driver);
        }

        /// <summary>
        ///     <see cref="LogsManager" />
        /// </summary>
        /// <param name="options">The <see cref="IOptions" /> instance, that  allows the user to set options on the browser.</param>
        public static LogsManager Logs([NotNull] this IOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            return new LogsManager(options);
        }

        /// <summary>
        ///     <see cref="Drelanium.MouseMoveFollower" />
        /// </summary>
        /// <param name="options">The <see cref="IOptions" /> instance, that  allows the user to set options on the browser.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static MouseMoveFollower MouseMoveFollower([NotNull] this IOptions options, [NotNull] IWebDriver driver)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new MouseMoveFollower(driver);
        }

        /// <summary>
        ///     <see cref="Drelanium.Timeouts" />
        /// </summary>
        /// <param name="options">The <see cref="IOptions" /> instance, that  allows the user to set options on the browser.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Timeouts Timeouts([NotNull] this IOptions options, [NotNull] IWebDriver driver)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new Timeouts(driver);
        }

        /// <summary>
        ///     <see cref="Drelanium.Window" />
        /// </summary>
        /// <param name="options">The <see cref="IOptions" /> instance, that  allows the user to set options on the browser.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Window Window([NotNull] this IOptions options, [NotNull] IWebDriver driver)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new Window(driver);
        }
    }
}