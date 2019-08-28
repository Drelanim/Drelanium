using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using Serilog.Core;

namespace Drelanium.WebDriver
{
    /// <summary>
    ///     Methods to perform scroll in the browser.
    /// </summary>
    public class Scroll
    {
        /// <summary>
        ///     Methods to perform scroll in the browser.
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Scroll(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        /// </summary>
        /// <inheritdoc cref="IWebDriver" />
        private IWebDriver Driver { get; }

        /// <summary>
        ///     The method scrolls the document in the window by the given amount of pixels.
        /// </summary>
        /// <param name="x">The x coordinate in pixel along the horizontal axis of the document.</param>
        /// <param name="y">The y coordinate in pixel along the vertical axis of the document.</param>
        /// <param name="behaviour">To be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (level = Information) during
        ///     the method exeuction.
        /// </param>
        public void By(int x, int y, string behaviour = "smooth", Logger logger = null)
        {
            logger?.Information($"Scrolling By({x},{y})");

            Driver.ExecuteJavaScript($"window.scrollBy({{top: {x}, left: {y}, behaviour: '{behaviour}'}});");
        }

        /// <summary>
        ///     The method scrolls to a particular set of pixel coordinates in the document.
        /// </summary>
        /// <param name="x">The x coordinate in pixel along the horizontal axis of the document.</param>
        /// <param name="y">The y coordinate in pixel along the vertical axis of the document.</param>
        /// <param name="behaviour">To be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (level = Information) during
        ///     the method exeuction.
        /// </param>
        public void To(int x, int y, string behaviour = "smooth", Logger logger = null)
        {
            logger?.Information($"Scrolling To({x},{y})");

            Driver.ExecuteJavaScript($"window.scrollTo({{top: {x}, left: {y}, behaviour: '{behaviour}'}});");
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="behaviour">To be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (level = Information) during
        ///     the method exeuction.
        /// </param>
        public void ToBodyBottom(string behaviour = "smooth", Logger logger = null)
        {
            logger?.Information("Scrolling to the bottom of the body");

            Driver.ExecuteJavaScript(
                $"window.scrollTo({{top: document.body.scrollHeight, left: 0, behaviour: '{behaviour}'}});");
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="behaviour">To be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (level = Information) during
        ///     the method exeuction.
        /// </param>
        public void ToBodyTop(string behaviour = "smooth", Logger logger = null)
        {
            logger?.Information("Scrolling to the top of the body");


            Driver.ExecuteJavaScript(
                $"window.scrollTo({{top: -document.body.scrollHeight, left: 0, behaviour: '{behaviour}'}});");
        }
    }
}