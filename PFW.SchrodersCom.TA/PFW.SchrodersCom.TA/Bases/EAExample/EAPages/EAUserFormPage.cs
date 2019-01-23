using OpenQA.Selenium;
using PFW.SchrodersCom.TA.Bases.Support;
using TechTalk.SpecFlow;

namespace PFW.SchrodersCom.TA.Bases.EAExample.EAPages
{
    public class EAUserFormPage : BasePage
    {

        public EAUserFormPage(IWebDriver driver) : base(driver)
        {
            PageUrl = @"http://executeautomation.com/demosite/index.html";
        }

        public IWebElement TxtInitial => WebElementActions.FindWebElementByCSSSelector(Driver, "#Initial");

        public IWebElement TxtFirstName => WebElementActions.FindWebElementByCSSSelector(Driver,"#FirstName");

        public IWebElement TxtMiddleName => WebElementActions.FindWebElementByCSSSelector(Driver,"#MiddleName");
        public IWebElement BtnSave => WebElementActions.FindWebElementByCSSSelector(Driver, @"#details > table > tbody > tr:nth-child(7) > td > input[type=""button""]");





        public void FillFields(Table table)
        {
            dynamic parameters = CommonSteps.CreateDynamicTable(table);
            TxtInitial.SendKeys(parameters.Initial);
            TxtFirstName.SendKeys(parameters.FirstName);
            TxtMiddleName.SendKeys(parameters.MiddleName);
            BtnSave.Click();
        }









    }
}
