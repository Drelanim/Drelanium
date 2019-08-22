using OpenQA.Selenium;

namespace Drelanium.WebDriver
{
    /// <summary>To be added...</summary>
    public class Alert : IAlert
    {
        /// <summary>To be added...</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Alert(IWebDriver driver)
        {
            Driver = driver;
            AlertImplementation = driver.SwitchTo().Alert();
        }

        /// <summary>To be added...</summary>
        private IAlert AlertImplementation { get; }

        /// <summary>To be added...</summary>
        private IWebDriver Driver { get; }

        public void Dismiss()
        {
            AlertImplementation.Dismiss();
        }

        public void Accept()
        {
            AlertImplementation.Accept();
        }

        public void SendKeys(string keysToSend)
        {
            AlertImplementation.SendKeys(keysToSend);
        }

        public void SetAuthenticationCredentials(string userName, string password)
        {
            AlertImplementation.SetAuthenticationCredentials(userName, password);
        }

        public string Text => AlertImplementation.Text;
    }
}