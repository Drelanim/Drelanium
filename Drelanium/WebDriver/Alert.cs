using OpenQA.Selenium;

namespace Drelanium
{
    /// <summary>
    ///     Extended implementation of <see cref="IAlert" />
    /// </summary>
    public class Alert : IAlert
    {
        /// <summary>
        ///     <inheritdoc cref="Alert" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Alert(IWebDriver driver)
        {
            Driver = driver;
            AlertImplementation = driver.SwitchTo().Alert();
        }

        /// <summary>
        ///     <inheritdoc cref="IAlert" />
        /// </summary>

        private IAlert AlertImplementation { get; }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>

        private IWebDriver Driver { get; }

        /// <summary>
        ///     <inheritdoc cref="IAlert.Dismiss()" />
        /// </summary>
        public void Dismiss()
        {
            AlertImplementation.Dismiss();
        }

        /// <summary>
        ///     <inheritdoc cref="IAlert.Accept()" />
        /// </summary>
        public void Accept()
        {
            AlertImplementation.Accept();
        }

        /// <summary>
        ///     <inheritdoc cref="IAlert.SendKeys(string)" />
        /// </summary>
        public void SendKeys(string keysToSend)
        {
            AlertImplementation.SendKeys(keysToSend);
        }

        /// <summary>
        ///     <inheritdoc cref="IAlert.SetAuthenticationCredentials(string,string)" />
        /// </summary>
        public void SetAuthenticationCredentials(string userName, string password)
        {
            AlertImplementation.SetAuthenticationCredentials(userName, password);
        }

        /// <summary>
        ///     <inheritdoc cref="IAlert.Text" />
        /// </summary>
        public string Text => AlertImplementation.Text;
    }
}