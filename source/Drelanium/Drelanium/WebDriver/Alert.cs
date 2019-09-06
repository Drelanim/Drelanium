using System;
using JetBrains.Annotations;
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
        public Alert([NotNull] IWebDriver driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
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
        public void SendKeys([NotNull] string keysToSend)
        {
            if (keysToSend == null) throw new ArgumentNullException(nameof(keysToSend));

            AlertImplementation.SendKeys(keysToSend);
        }

        /// <summary>
        ///     <inheritdoc cref="IAlert.SetAuthenticationCredentials(string,string)" />
        /// </summary>
        public void SetAuthenticationCredentials([NotNull] string userName, [NotNull] string password)
        {
            if (userName == null) throw new ArgumentNullException(nameof(userName));
            if (password == null) throw new ArgumentNullException(nameof(password));

            AlertImplementation.SetAuthenticationCredentials(userName, password);
        }

        /// <summary>
        ///     <inheritdoc cref="IAlert.Text" />
        /// </summary>
        public string Text => AlertImplementation.Text;
    }
}