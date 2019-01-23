using OpenQA.Selenium;

namespace PFW.SchrodersCom.TA.Bases
{
    public class BasePage
    {
        public IWebDriver Driver { get; set; }

        public string PageUrl { get; set; }

        public BasePage(IWebDriver driver) => Driver = driver;









    }
}
