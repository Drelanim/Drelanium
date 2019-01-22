using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using PFW.SchrodersCom.TA.BaseClasses;

namespace PFW.SchrodersCom.TA.Pages
{
    public class EALoginPage : BasePage
    {

        public EALoginPage(IWebDriver driver) : base(driver)
        {
            PageUrl = @"http://executeautomation.com/demosite/Login.html";
        }


        public IWebElement TxtUserName => FindWebElementByCSSSelector("#userName > p:nth-child(1) > input[type=\"text\"]");

        public IWebElement TxtPassword => FindWebElementByCSSSelector("#userName > p:nth-child(2) > input[type=\"text\"]");
   
        public IWebElement BtnLogin => FindWebElementByCSSSelector("#userName > p:nth-child(3) > input[type=\"submit\"]");

        public void FillEALoginPageFields()
        {
            TxtUserName.SendKeys("attila");
            TxtPassword.SendKeys("nyiri");
        }






    }
}
