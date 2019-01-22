using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using PFW.SchrodersCom.TA.BaseClasses;

namespace PFW.SchrodersCom.TA.Pages
{
    public class EAUserFormPage : BasePage
    {

        public EAUserFormPage(IWebDriver driver) : base(driver)
        {
            PageUrl = @"http://executeautomation.com/demosite/index.html";
        }

        public IWebElement TxtInitial => FindWebElementByCSSSelector("#Initial");

        public IWebElement TxtFirstName => FindWebElementByCSSSelector("#Initial");

        public IWebElement TxtMiddleName => FindWebElementByCSSSelector("#MiddleName");


        public void FillEAUserFormPageFields()
        {
            TxtInitial.SendKeys("initial");
            TxtFirstName.SendKeys("Attila");
            TxtMiddleName.SendKeys("Nyiri");
        }


        public bool CheckIfUserFormIsFilled()
        {
            if ((TxtInitial.Text != string.Empty)&&
                (TxtFirstName.Text != string.Empty)&&
                (TxtMiddleName.Text != string.Empty))
            {
                return true;
            }
            return false;
        }
                





    }
}
