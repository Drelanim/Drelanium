using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TestCommon;

namespace WebFuntionalTests.PageObjects.Schroders
{
    public class SchrodersShowMePage : SeleniumPageBase
    {
        // page URL
        private string pageUrl;

        // default constructor when we just want to create page object without navigating and with driver already active 
        public SchrodersShowMePage(RemoteWebDriver driver) : base(driver)
        {
        }

        // constructor with optional page loading
        public SchrodersShowMePage(object browserOptions, string url = null)
            : base(browserOptions)
        {
            if (url != null)
            {
                pageUrl = url;
                try
                {
                    Driver.Navigate().GoToUrl(pageUrl);
                }
                catch (Exception e)
                {
                    // ignore navigate exceptions
                }
            }
        }


        // Widget Locators

        // link containers
        public By AboutUsContainer = By.XPath("//*[@id=\"main-nav\"]/ul/li[1]/div[2]/div[1]/div/div[1]");
        public By StrategicCapabilitiesContainer = By.XPath("//*[@id=\"main-nav\"]/ul/li[1]/div[2]/div[1]/div/div[2]");
        public By InsightsContainer = By.XPath("//*[@id=\"main-nav\"]/ul/li[1]/div[2]/div[1]/div/div[3]");
        public By PeopleContainer = By.XPath("//*[@id=\"main-nav\"]/ul/li[1]/div[2]/div[1]/div/div[4]");
        public By MediaRelationsContainer = By.XPath("//*[@id=\"main-nav\"]/ul/li[1]/div[2]/div[2]/div/div[1]");
        public By InvestorRelationsContainer = By.XPath("//*[@id=\"main-nav\"]/ul/li[1]/div[2]/div[2]/div/div[2]");
        public By CazenoveCapitalContainer = By.XPath("//*[@id=\"main-nav\"]/ul/li[1]/div[2]/div[2]/div/div[3]");
        public By FollowUsContainer = By.XPath("  //*[@id=\"main-nav\"]/ul/li[1]/div[2]/div[2]/div/div[4]");

       



        // Page Methods
        // < public mothods of the page objcect go here...>


    }
}
