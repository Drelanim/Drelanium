using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;


namespace Drelanium.WebDriver
{

    public class Scroll
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public Scroll(IWebDriver driver)
        {
            Driver = driver;
        }

        private IWebDriver Driver { get; }

        /// <param name="x">The x coordinate in pixel along the horizontal axis of the document.</param>
        /// <param name="y">The y coordinate in pixel along the vertical axis of the document.</param>
        public void To(int x, int y, string behaviour = "smooth")
        {
            Driver.ExecuteJavaScript($"window.scrollTo({{top: {x}, left: {y}, behaviour: '{behaviour}'}});");
        }

        public void ToBodyBottom(string behaviour = "smooth")
        {
            Driver.ExecuteJavaScript($"window.scrollTo({{top: document.body.scrollHeight, left: 0, behaviour: '{behaviour}'}});");
        }

        public void ToBodyTop(string behaviour = "smooth")
        {
            Driver.ExecuteJavaScript($"window.scrollTo({{top: -document.body.scrollHeight, left: 0, behaviour: '{behaviour}'}});");
        }

        /// <param name="x">The x coordinate in pixel along the horizontal axis of the document.</param>
        /// <param name="y">The y coordinate in pixel along the vertical axis of the document.</param>
        public void By(int x, int y, string behaviour = "smooth")
        {
            Driver.ExecuteJavaScript($"window.scrollBy({{top: {x}, left: {y}, behaviour: '{behaviour}'}});");
        }

    }

}