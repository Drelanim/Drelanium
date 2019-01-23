using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace PFW.SchrodersCom.TA.Bases
{
    public class BasePage
    {
        public RemoteWebDriver Driver { get; set; }

        public string PageUrl { get; set; }

        public BasePage(RemoteWebDriver driver) => Driver = driver;









    }
}
