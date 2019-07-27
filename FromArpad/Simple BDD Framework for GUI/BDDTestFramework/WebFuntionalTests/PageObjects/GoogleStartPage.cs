using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TestCommon;

namespace WebFuntionalTests.PageObjects
{
    public class GoogleStartPage : SeleniumPageBase
    {
        // page URL
        private string pageUrl;

        // default constructor when we just want to create page object without navigating and with driver already active 
        public GoogleStartPage(RemoteWebDriver driver) : base(driver)
        {
        }

        // constructor with optional page loading
        public GoogleStartPage(object browserOptions, string url = null)
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
        //*[@id="tsf"]/div[2]/div/div[1]/div/div[1]/input
        public By searchField = By.XPath("//*[@id=\"tsf\"]/div[2]/div/div[1]/div/div[1]/input");

        // Page Methods
        // < public mothods of the page objcect go here...>


    }
}
