using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TestCommon;

namespace WebFuntionalTests.PageObjects.Schroders
{
    public class SchrodersSearchPage : SeleniumPageBase
    {
        // page URL
        private string pageUrl;

        // default constructor when we just want to create page object without navigating and with driver already active 
        public SchrodersSearchPage(RemoteWebDriver driver) : base(driver)
        {
        }

        // constructor with optional page loading
        public SchrodersSearchPage(object browserOptions, string url = null)
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
        public By searchBox = By.XPath("//*[@id=\"findInputHeader\"]");
        public By searchButton = By.XPath("//*[@id=\"findInputButton\"]");
        public By notFoundParagraph = By.XPath("//*[@id=\"findPage\"]/div[4]/div[3]/div/div/div/div/div/p");





        // Page Methods
        // < public mothods of the page objcect go here...>


    }
}
