using OpenQA.Selenium;

namespace Drelanium.WebDriver
{
    /// <summary>
    ///To be added...
    ///</summary>
    public class Alert : IAlert
    {
        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Alert(IWebDriver driver)
        {
            Driver = driver;
            AlertImplementation = driver.SwitchTo().Alert();
        }


        /// <inheritdoc cref="IAlert"/>
        private IAlert AlertImplementation { get; }


        /// <inheritdoc cref="IWebDriver"/>
        private IWebDriver Driver { get; }


        /// <inheritdoc></inheritdoc>
        public void Dismiss()
        {
            AlertImplementation.Dismiss();
        }


        /// <inheritdoc></inheritdoc>
        public void Accept()
        {
            AlertImplementation.Accept();
        }


        /// <inheritdoc></inheritdoc>
        public void SendKeys(string keysToSend)
        {
            AlertImplementation.SendKeys(keysToSend);
        }


        /// <inheritdoc></inheritdoc>
        public void SetAuthenticationCredentials(string userName, string password)
        {
            AlertImplementation.SetAuthenticationCredentials(userName, password);
        }


        /// <inheritdoc></inheritdoc>
        public string Text => AlertImplementation.Text;
    }
}