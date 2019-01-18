using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TestCommon;

namespace WebFuntionalTests.PageObjects.Schroders
{
    public class SchrodersStartPage : SeleniumPageBase
    {
        // page URL
        private string pageUrl;

        // default constructor when we just want to create page object without navigating and with driver already active 
        public SchrodersStartPage(RemoteWebDriver driver) : base(driver)
        {
        }

        // constructor with optional page loading
        public SchrodersStartPage(object browserOptions, string url = null)
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

        // page top area
        public By ShowMeButton = By.XPath("//*[@id=\"main-nav\"]/ul/li[1]/a");
        public By SearchButton = By.XPath("//*[@id=\"main-nav\"]/ul/li[3]/a[2]/i");

        // three tab panes
        public By InsightsPane = By.XPath("//button[@data-index=\'1\' and text()[contains(.,\'Insights\')]]");
        public By AboutUsPane = By.XPath("//button[@data-index=\'2\' and text()[contains(.,\'About Us\')]]");
        public By PeoplePane = By.XPath("//button[@data-index=\'3\' and text()[contains(.,\'People\')]]");

        // Insights Pane Most Recent menu
        // note: these two locators have variable name parameter denoted by **** and will need to be substituted before use
        public By InsightsPullDownMenu = By.XPath("//button[@class=\'btn btn-default btn-block dropdown toggle-menu\' and text()[contains(.,\'***\')]]");
        public By InsightsPullDownMenuItem = By.XPath($"//div[@class=\'dropdown-menu-options is-active\']//li[text()[contains(.,\'***\')]]");

        // Page Methods
        // < public mothods of the page objcect go here...>

        // this method click on a menu and returns the webelement of a menu item
        // uses generalized locators that are instantiated by text attribute
        public IWebElement GetMenuItem(By menuLocator, By itemLocator, string menuName, string menuItemName)
        {

            // this segment performs the substitution and forms the actual item locators to use
            var itemXpathString = (itemLocator.ToString().Replace("***", menuItemName)).Remove(0, 9);
            var itemXpath = By.XPath(itemXpathString);
            var menuXpathString = (menuLocator.ToString().Replace("***", menuName)).Remove(0, 9);
            var menuXpath = By.XPath(menuXpathString);

            // execute the menu click
            LocateWidget(menuXpath).Click();
            var itemWidget = LocateWidget(itemXpath);

            // return the item widget
            return itemWidget;
        }
    }
}
