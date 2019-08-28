using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Drelanium.Extensions.IWebDriverExtensionMethods;
using OpenQA.Selenium;
using Serilog.Core;

namespace Drelanium.WebDriver
{
    /// <summary>
    ///     Extended implementation of <see cref="ICookieJar" />
    /// </summary>
    public class CookieJar : ICookieJar
    {
        /// <summary>
        ///     <see cref="CookieJar" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public CookieJar(IWebDriver driver)
        {
            Driver = driver;
            CookieJarImplementation = driver.Manage().Cookies;
        }

        /// <summary>
        /// </summary>
        /// <inheritdoc cref="ICookieJar" />
        private ICookieJar CookieJarImplementation { get; }

        /// <summary>
        /// </summary>
        /// <inheritdoc cref="IWebDriver" />
        private IWebDriver Driver { get; }


        /// <summary>
        ///     <inheritdoc></inheritdoc>
        /// </summary>
        public void AddCookie(Cookie cookie)
        {
            CookieJarImplementation.AddCookie(cookie);
        }

        /// <summary>
        ///     <inheritdoc></inheritdoc>
        /// </summary>
        public Cookie GetCookieNamed(string name)
        {
            return CookieJarImplementation.GetCookieNamed(name);
        }

        /// <summary>
        ///     <inheritdoc></inheritdoc>
        /// </summary>
        public void DeleteCookie(Cookie cookie)
        {
            CookieJarImplementation.DeleteCookie(cookie);
        }

        /// <summary>
        ///     <inheritdoc></inheritdoc>
        /// </summary>
        public void DeleteCookieNamed(string name)
        {
            CookieJarImplementation.DeleteCookieNamed(name);
        }

        /// <summary>
        ///     <inheritdoc></inheritdoc>
        /// </summary>
        public void DeleteAllCookies()
        {
            CookieJarImplementation.DeleteAllCookies();
        }

        /// <summary>
        ///     <inheritdoc></inheritdoc>
        /// </summary>
        public ReadOnlyCollection<Cookie> AllCookies => CookieJarImplementation.AllCookies;

        /// <summary>
        /// </summary>
        /// <inheritdoc cref="AddCookie(Cookie)" />
        public void AddCookie(Cookie cookie, Logger logger)
        {
            logger?.Information($"Adding cookie {cookie}");

            AddCookie(cookie);
        }

        /// <summary>
        /// </summary>
        /// <inheritdoc cref="GetCookieNamed(string)" />
        public Cookie GetCookieNamed(string name, Logger logger)
        {
            logger?.Information($"Getting cookie named {name}");

            return GetCookieNamed(name);
        }

        /// <summary>
        /// </summary>
        /// <inheritdoc cref="DeleteCookie(Cookie)" />
        public void DeleteCookie(Cookie cookie, Logger logger)
        {
            logger?.Information($"Deleting cookie {cookie}");

            DeleteCookie(cookie);

            logger?.Information($"Deleted cookie {cookie}");
        }

        /// <summary>
        /// </summary>
        /// <inheritdoc cref="DeleteCookieNamed(string)" />
        public void DeleteCookieNamed(string name, Logger logger)
        {
            logger?.Information($"Deleting cookie named {name}");

            DeleteCookieNamed(name);

            logger?.Information($"Deleted cookie named {name}");
        }

        /// <summary>
        /// </summary>
        /// <inheritdoc cref="DeleteAllCookies()" />
        public void DeleteAllCookies(Logger logger)
        {
            logger?.Information($"Deleting all available cookies in current domain: ({Driver.Url().Host})");

            DeleteAllCookies();

            logger?.Information($"Deleted all available cookies in current domain: ({Driver.Url().Host})");
        }


        /// <summary>
        ///     To be added...
        /// </summary>
        private void CheckDomain(string domainName, Logger logger = null)
        {
            var actualDomain = Driver.Url().Host;

            logger?.Information($"Comparing actual domain ({actualDomain}) to expected ({domainName})");

            if (actualDomain != domainName)
            {
                throw new InvalidCookieDomainException(
                    $"Actual domain ({actualDomain}) is not equal to the expected ({domainName}) domain");
            }

            logger?.Information("Domain compare passed");
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public Cookie GetCookieNamed(string domainName, string name, Logger logger = null)
        {
            CheckDomain(domainName, logger);
            return GetCookieNamed(name, logger);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public void DeleteCookie(string domainName, Cookie cookie, Logger logger = null)
        {
            CheckDomain(domainName, logger);
            DeleteCookie(cookie, logger);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public void DeleteCookieNamed(string domainName, string name, Logger logger = null)
        {
            CheckDomain(domainName, logger);
            DeleteCookieNamed(name, logger);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public void DeleteAllCookies(string domainName, Logger logger = null)
        {
            CheckDomain(domainName, logger);
            DeleteAllCookies(logger);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public IEnumerable<Cookie> DomainCookies(string domainName, Logger logger = null)
        {
            CheckDomain(domainName, logger);

            logger?.Information($"Getting cookies from domain ({domainName})");

            return AllCookies.Where(cookie => cookie.Domain == domainName);
        }
    }
}