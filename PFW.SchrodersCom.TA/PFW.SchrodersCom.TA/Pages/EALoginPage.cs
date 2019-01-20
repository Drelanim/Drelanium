using OpenQA.Selenium;
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

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }


        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }


        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }



        public void FillEALoginPageFields()
        {
            txtUserName.SendKeys("nyiriattila88@gmail.com");
            txtPassword.SendKeys("goodPass%1");
        }

        public void ClickLogin()
        {
            btnLogin.Submit();
        }






    }
}
