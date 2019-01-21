using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using PFW.SchrodersCom.TA.BaseClasses;

namespace PFW.SchrodersCom.TA.Pages
{
    public class EALoginPage : BasePage
    {

        public EALoginPage(RemoteWebDriver driver) : base(driver)
        {
            PageUrl = @"http://executeautomation.com/demosite/Login.html";
        }




        public IWebElement txtUserName => Driver.FindElementByName("UserName");
 
        public IWebElement txtPassword => Driver.FindElementByName("Password");
   
        public IWebElement btnLogin => Driver.FindElementByName("Login");



        public void FillEALoginPageFields()
        {
            txtUserName.SendKeys("attila");
            txtPassword.SendKeys("nyiri");
        }

        public void ClickLogin()
        {
            btnLogin.Submit();
        }






    }
}
