using OpenQA.Selenium;

namespace Drelanium.WebDriver
{
    /// <summary>
    /// Extended implementation of <see cref="IAlert"/>
    ///</summary>
    public class Alert : IAlert
    {
        /// <summary>
        /// <see cref="Alert"/>
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Alert(IWebDriver driver)
        {
            Driver = driver;
            AlertImplementation = driver.SwitchTo().Alert();
        }

        /// <summary>
        ///
        /// </summary>
        /// <inheritdoc cref="IAlert"/>
        private IAlert AlertImplementation { get; }

        /// <summary>
        ///
        /// </summary>
        /// <inheritdoc cref="IWebDriver"/>
        private IWebDriver Driver { get; }


        /// <summary>
        /// <inheritdoc></inheritdoc>
        /// </summary>
        public void Dismiss()
        {
            AlertImplementation.Dismiss();
        }


        /// <summary>
        /// <inheritdoc></inheritdoc>
        /// </summary>
        public void Accept()
        {
            AlertImplementation.Accept();
        }


        /// <summary>
        /// <inheritdoc></inheritdoc>
        /// </summary>
        public void SendKeys(string keysToSend)
        {
            AlertImplementation.SendKeys(keysToSend);
        }


        /// <summary>
        /// <inheritdoc></inheritdoc>
        /// </summary>
        public void SetAuthenticationCredentials(string userName, string password)
        {
            AlertImplementation.SetAuthenticationCredentials(userName, password);
        }


        /// <summary>
        /// <inheritdoc></inheritdoc>
        /// </summary>
        public string Text => AlertImplementation.Text;
    }
}