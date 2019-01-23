using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using PFW.SchrodersCom.TA.Bases.Support;

namespace PFW.SchrodersCom.TA.Bases.EAExample.EAPages
{
    public class EALoginPage : BasePage
    {

        public EALoginPage(RemoteWebDriver driver) : base(driver)
        {
            PageUrl = @"http://executeautomation.com/demosite/Login.html";
        }


        public IWebElement TxtUserName => WebElementActions.FindWebElementByCSSSelector(Driver, "#userName > p:nth-child(1) > input[type=\"text\"]");

        public IWebElement TxtPassword => WebElementActions.FindWebElementByCSSSelector(Driver, "#userName > p:nth-child(2) > input[type=\"text\"]");
   
        public IWebElement BtnLogin => WebElementActions.FindWebElementByCSSSelector(Driver, "#userName > p:nth-child(3) > input[type=\"submit\"]");




        public void FillFields()
        {
            TxtUserName.SendKeys("attila");
            TxtPassword.SendKeys("nyiri");
        }

        public void Login()
        {
            BtnLogin.Submit();
        }






    }
}
