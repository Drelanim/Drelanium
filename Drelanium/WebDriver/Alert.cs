using Drelanium.Extensions.IWebDriverExtensionMethods;
using OpenQA.Selenium;


namespace Drelanium.WebDriver
{

    public class Alert : IAlert
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public Alert(IWebDriver driver)
        {
            Driver = driver;
            AlertImplementation = driver.SwitchTo().Alert();
        }

        private IAlert AlertImplementation { get; }
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