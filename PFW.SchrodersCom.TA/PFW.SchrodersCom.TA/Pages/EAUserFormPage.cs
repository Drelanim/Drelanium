using OpenQA.Selenium;
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


        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }


        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }


        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }


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
