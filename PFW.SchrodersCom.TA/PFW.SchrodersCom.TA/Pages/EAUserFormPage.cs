using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using PFW.SchrodersCom.TA.BaseClasses;

namespace PFW.SchrodersCom.TA.Pages
{
    public class EAUserFormPage : BasePage
    {

        public EAUserFormPage(RemoteWebDriver driver) : base(driver)
        {
            PageUrl = @"http://executeautomation.com/demosite/index.html";
        }

        public IWebElement txtInitial => Driver.FindElementByName("Initial");

        public IWebElement txtFirstName => Driver.FindElementByName("FirstName");

        public IWebElement txtMiddleName => Driver.FindElementByName("MiddleName");


        public void FillEAUserFormPageFields()
        {
            txtInitial.SendKeys("initial");
            txtFirstName.SendKeys("Attila");
            txtMiddleName.SendKeys("Nyiri");
        }


        public bool CheckIfUserFormIsFilled()
        {
            if ((txtInitial.Text != string.Empty)&&
                (txtFirstName.Text != string.Empty)&&
                (txtMiddleName.Text != string.Empty))
            {
                return true;
            }
            return false;
        }
                





    }
}
