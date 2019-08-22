using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Drelanium.Extensions.IWebDriverExtensionMethods;
using OpenQA.Selenium;
using Serilog.Core;

namespace Drelanium.WebDriver
{
    /// <summary>
 ///To be added...
 ///</summary>
    public class CookieJar : ICookieJar
    {
        /// <summary>
 ///To be added...
 ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public CookieJar(IWebDriver driver)
        {
            Driver = driver;
            CookieJarImplementation = driver.Manage().Cookies;
        }

        /// <summary>
 ///To be added...
 ///</summary>
        private ICookieJar CookieJarImplementation { get; }

        /// <summary>
        /// The browser, that is represented by an <see cref="IWebDriver" /> instance.
        ///</summary>
        private IWebDriver Driver { get; }

        /// <summary>
 ///To be added..
 ///</summary>
        public void AddCookie(Cookie cookie)
        {
            CookieJarImplementation.AddCookie(cookie);
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public Cookie GetCookieNamed(string name)
        {
            return CookieJarImplementation.GetCookieNamed(name);
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public void DeleteCookie(Cookie cookie)
        {
            CookieJarImplementation.DeleteCookie(cookie);
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public void DeleteCookieNamed(string name)
        {
            CookieJarImplementation.DeleteCookieNamed(name);
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public void DeleteAllCookies()
        {
            CookieJarImplementation.DeleteAllCookies();
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public ReadOnlyCollection<Cookie> AllCookies => CookieJarImplementation.AllCookies;

        /// <summary>
 ///To be added...
 ///</summary>
        public void AddCookie(Cookie cookie, Logger logger = null)
        {
            logger?.Information($"Adding cookie {cookie}");

            AddCookie(cookie);
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public Cookie GetCookieNamed(string name, Logger logger = null)
        {
            logger?.Information($"Getting cookie named {name}");

            return GetCookieNamed(name);
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public void DeleteCookie(Cookie cookie, Logger logger = null)
        {
            logger?.Information($"Deleting cookie {cookie}");

            DeleteCookie(cookie);

            logger?.Information($"Deleted cookie {cookie}");
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public void DeleteCookieNamed(string name, Logger logger = null)
        {
            logger?.Information($"Deleting cookie named {name}");

            DeleteCookieNamed(name);

            logger?.Information($"Deleted cookie named {name}");
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public void DeleteAllCookies(Logger logger = null)
        {
            logger?.Information($"Deleting all available cookies in current domain: ({Driver.Url().Host})");

            DeleteAllCookies();

            logger?.Information($"Deleted all available cookies in current domain: ({Driver.Url().Host})");
        }

        /// <summary>
 ///To be added...
 ///</summary>
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
 ///To be added...
 ///</summary>
        public Cookie GetCookieNamed(string domainName, string name, Logger logger = null)
        {
            CheckDomain(domainName, logger);
            return GetCookieNamed(name, logger);
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public void DeleteCookie(string domainName, Cookie cookie, Logger logger = null)
        {
            CheckDomain(domainName, logger);
            DeleteCookie(cookie, logger);
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public void DeleteCookieNamed(string domainName, string name, Logger logger = null)
        {
            CheckDomain(domainName, logger);
            DeleteCookieNamed(name, logger);
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public void DeleteAllCookies(string domainName, Logger logger = null)
        {
            CheckDomain(domainName, logger);
            DeleteAllCookies(logger);
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public IEnumerable<Cookie> DomainCookies(string domainName, Logger logger = null)
        {
            CheckDomain(domainName, logger);

            logger?.Information($"Getting cookies from domain ({domainName})");

            return AllCookies.Where(cookie => cookie.Domain == domainName);
        }
    }
}