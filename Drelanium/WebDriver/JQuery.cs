using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Drelanium.WebDriver
{
    /// <summary>
 ///To be added...</summary>
    public class JQuery
    {
        /// <summary>
 ///To be added...</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public JQuery(IWebDriver driver)
        {
            

            Driver = driver;

            


        }

        /// <summary>
        /// The browser, that is represented by an <see cref="IWebDriver" /> instance.
        ///</summary>
        private IWebDriver Driver { get; }

        /// <summary>
 ///To be added...</summary>
        public bool Active => Driver.ExecuteJavaScript<bool>("return jQuery.active == 0");
    }
}