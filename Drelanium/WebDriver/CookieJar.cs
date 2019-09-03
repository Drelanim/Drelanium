using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using JetBrains.Annotations;
using OpenQA.Selenium;
using Serilog.Core;

namespace Drelanium
{
    /// <summary>
    ///     Extended implementation of <see cref="ICookieJar" />
    /// </summary>
    public class CookieJar : ICookieJar
    {
        /// <summary>
        ///     <inheritdoc cref="CookieJar" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public CookieJar([NotNull] IWebDriver driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            CookieJarImplementation = driver.Manage().Cookies;
        }

        /// <summary>
        ///     <inheritdoc cref="ICookieJar" />
        /// </summary>

        private ICookieJar CookieJarImplementation { get; }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>
        private IWebDriver Driver { get; }

        /// <summary>
        ///     <inheritdoc cref="ICookieJar.AddCookie(Cookie)" />
        /// </summary>
        public void AddCookie([NotNull] Cookie cookie)
        {
            if (cookie == null) throw new ArgumentNullException(nameof(cookie));

            CookieJarImplementation.AddCookie(cookie);
        }

        /// <summary>
        ///     <inheritdoc cref="ICookieJar.GetCookieNamed(string)" />
        /// </summary>
        public Cookie GetCookieNamed([NotNull] string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            return CookieJarImplementation.GetCookieNamed(name);
        }

        /// <summary>
        ///     <inheritdoc cref="ICookieJar.DeleteCookie(Cookie)" />
        /// </summary>
        public void DeleteCookie([NotNull] Cookie cookie)
        {
            if (cookie == null) throw new ArgumentNullException(nameof(cookie));

            CookieJarImplementation.DeleteCookie(cookie);
        }

        /// <summary>
        ///     <inheritdoc cref="ICookieJar.DeleteCookieNamed(string)" />
        /// </summary>
        public void DeleteCookieNamed([NotNull] string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            CookieJarImplementation.DeleteCookieNamed(name);
        }

        /// <summary>
        ///     <inheritdoc cref="ICookieJar.DeleteAllCookies()" />
        /// </summary>
        public void DeleteAllCookies()
        {
            CookieJarImplementation.DeleteAllCookies();
        }

        /// <summary>
        ///     <inheritdoc cref="ICookieJar.AllCookies" />
        /// </summary>
        public ReadOnlyCollection<Cookie> AllCookies => CookieJarImplementation.AllCookies;

        /// <summary>
        ///     <inheritdoc cref="ICookieJar.AddCookie(Cookie)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        public void AddCookie([NotNull] Cookie cookie, [CanBeNull] Logger logger)
        {
            if (cookie == null) throw new ArgumentNullException(nameof(cookie));

            logger?.Information($"Adding cookie {cookie}.");

            AddCookie(cookie);
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        private void CheckDomain([NotNull] string domainName, [CanBeNull] Logger logger = null)
        {
            if (domainName == null) throw new ArgumentNullException(nameof(domainName));

            var actualDomain = Driver.Url().Host;

            logger?.Information($"Comparing actual domain ({actualDomain}) to expected ({domainName}).");

            if (actualDomain != domainName)
            {
                throw new InvalidCookieDomainException(
                    $"Actual domain ({actualDomain}) is not equal to the expected ({domainName}) domain.");
            }

            logger?.Information("Domain compare passed.");
        }

        /// <summary>
        ///     <inheritdoc cref="ICookieJar.DeleteAllCookies()" />
        ///     <para>Logs the event.</para>
        /// </summary>
        public void DeleteAllCookies([CanBeNull] Logger logger)
        {
            logger?.Information($"Deleting all available cookies in current domain: ({Driver.Url().Host}).");

            DeleteAllCookies();

            logger?.Information($"Deleted all available cookies in current domain: ({Driver.Url().Host}).");
        }

        /// <summary>
        ///     <inheritdoc cref="ICookieJar.DeleteAllCookies()" />
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        public void DeleteAllCookies([NotNull] string domainName, [CanBeNull] Logger logger = null)
        {
            if (domainName == null) throw new ArgumentNullException(nameof(domainName));

            CheckDomain(domainName, logger);
            DeleteAllCookies(logger);
        }

        /// <summary>
        ///     <inheritdoc cref="ICookieJar.DeleteCookie(Cookie)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        public void DeleteCookie([NotNull] Cookie cookie, [CanBeNull] Logger logger)
        {
            if (cookie == null) throw new ArgumentNullException(nameof(cookie));

            logger?.Information($"Deleting cookie {cookie}.");

            DeleteCookie(cookie);

            logger?.Information($"Deleted cookie {cookie}.");
        }

        /// <summary>
        ///     <inheritdoc cref="ICookieJar.DeleteCookie(Cookie)" />
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        public void DeleteCookie([NotNull] string domainName, [NotNull] Cookie cookie, [CanBeNull] Logger logger = null)
        {
            if (domainName == null) throw new ArgumentNullException(nameof(domainName));
            if (cookie == null) throw new ArgumentNullException(nameof(cookie));

            CheckDomain(domainName, logger);
            DeleteCookie(cookie, logger);
        }

        /// <summary>
        ///     <inheritdoc cref="DeleteCookieNamed(string)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        public void DeleteCookieNamed([NotNull] string name, [CanBeNull] Logger logger)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            logger?.Information($"Deleting cookie named {name}.");

            DeleteCookieNamed(name);

            logger?.Information($"Deleted cookie named {name}.");
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        public void DeleteCookieNamed([NotNull] string domainName, [NotNull] string name,
            [CanBeNull] Logger logger = null)
        {
            if (domainName == null) throw new ArgumentNullException(nameof(domainName));
            if (name == null) throw new ArgumentNullException(nameof(name));

            CheckDomain(domainName, logger);
            DeleteCookieNamed(name, logger);
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        public IEnumerable<Cookie> DomainCookies([NotNull] string domainName, [CanBeNull] Logger logger = null)
        {
            if (domainName == null) throw new ArgumentNullException(nameof(domainName));

            CheckDomain(domainName, logger);

            logger?.Information($"Getting cookies from domain ({domainName}).");

            return AllCookies.Where(cookie => cookie.Domain == domainName);
        }

        /// <summary>
        ///     <inheritdoc cref="GetCookieNamed(string)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        public Cookie GetCookieNamed([NotNull] string name, [CanBeNull] Logger logger)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            logger?.Information($"Getting cookie named {name}.");

            return GetCookieNamed(name);
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        public Cookie GetCookieNamed([NotNull] string domainName, [NotNull] string name,
            [CanBeNull] Logger logger = null)
        {
            if (domainName == null) throw new ArgumentNullException(nameof(domainName));
            if (name == null) throw new ArgumentNullException(nameof(name));

            CheckDomain(domainName, logger);
            return GetCookieNamed(name, logger);
        }
    }
}