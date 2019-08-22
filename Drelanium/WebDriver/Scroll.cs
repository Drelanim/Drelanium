using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using Serilog.Core;

namespace Drelanium.WebDriver
{
    /// <summary>To be added...</summary>
    public class Scroll
    {
        /// <summary>To be added...</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Scroll(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>To be added...</summary>
        private IWebDriver Driver { get; }

        /// <summary>To be added...</summary>
        /// <param name="x">The x coordinate in pixel along the horizontal axis of the document.</param>
        /// <param name="y">The y coordinate in pixel along the vertical axis of the document.</param>
        /// <param name="behaviour">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void To(int x, int y, string behaviour = "smooth", Logger logger = null)
        {
            logger?.Information($"Scrolling To({x},{y})");

            Driver.ExecuteJavaScript($"window.scrollTo({{top: {x}, left: {y}, behaviour: '{behaviour}'}});");
        }

        /// <summary>To be added...</summary>
        /// <param name="behaviour">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void ToBodyBottom(string behaviour = "smooth", Logger logger = null)
        {
            logger?.Information("Scrolling to the bottom of the body");

            Driver.ExecuteJavaScript(
                $"window.scrollTo({{top: document.body.scrollHeight, left: 0, behaviour: '{behaviour}'}});");
        }

        /// <summary>To be added...</summary>
        /// <param name="behaviour">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void ToBodyTop(string behaviour = "smooth", Logger logger = null)
        {
            logger?.Information("Scrolling to the top of the body");

            Driver.ExecuteJavaScript(
                $"window.scrollTo({{top: -document.body.scrollHeight, left: 0, behaviour: '{behaviour}'}});");
        }

        /// <summary>To be added...</summary>
        /// <param name="x">The x coordinate in pixel along the horizontal axis of the document.</param>
        /// <param name="y">The y coordinate in pixel along the vertical axis of the document.</param>
        /// <param name="behaviour">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void By(int x, int y, string behaviour = "smooth", Logger logger = null)
        {
            logger?.Information($"Scrolling By({x},{y})");

            Driver.ExecuteJavaScript($"window.scrollBy({{top: {x}, left: {y}, behaviour: '{behaviour}'}});");
        }
    }
}