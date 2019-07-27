using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Drelanium.Extensions.IWebDriverExtensionMethods;
using OpenQA.Selenium;


namespace Drelanium.WebDriver
{

    public class CookieJar : ICookieJar
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public CookieJar(IWebDriver driver)
        {
            Driver = driver;
            CookieJarImplementation = driver.Manage().Cookies;
        }

        private ICookieJar CookieJarImplementation { get; }
        private IWebDriver Driver { get; }

        public void AddCookie(Cookie cookie)
        {
            CookieJarImplementation.AddCookie(cookie);
        }

        public Cookie GetCookieNamed(string name)
        {
            return CookieJarImplementation.GetCookieNamed(name);
        }

        public void DeleteCookie(Cookie cookie)
        {
            CookieJarImplementation.DeleteCookie(cookie);
        }

        public void DeleteCookieNamed(string name)
        {
            CookieJarImplementation.DeleteCookieNamed(name);
        }

        public void DeleteAllCookies()
        {
            CookieJarImplementation.DeleteAllCookies();
        }

        public ReadOnlyCollection<Cookie> AllCookies => CookieJarImplementation.AllCookies;

        private void CheckDomain(string domainName)
        {
            var actualDomain = Driver.Url().Host;

            if (actualDomain != domainName)
            {
                throw new InvalidCookieDomainException($"Actual domain ({actualDomain}) is not equal to the expected ({domainName}) domain");
            }
        }

        public Cookie GetCookieNamed(string domainName, string name)
        {
            CheckDomain(domainName);
            return GetCookieNamed(name);
        }

        public void DeleteCookie(string domainName, Cookie cookie)
        {
            CheckDomain(domainName);
            DeleteCookie(cookie);
        }

        public void DeleteCookieNamed(string domainName, string name)
        {
            CheckDomain(domainName);
            DeleteCookieNamed(name);
        }

        public void DeleteAllCookies(string domainName)
        {
            CheckDomain(domainName);
            DeleteAllCookies();
        }

        public IEnumerable<Cookie> DomainCookies(string domainName)
        {
            CheckDomain(domainName);
            return AllCookies.Where(cookie => cookie.Domain == domainName);
        }

    }

}