using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Xml.XPath;
using System.Xml;
using System.Xml.Linq;
using System.Configuration;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using PFW.SchrodersCom.TA.Setup;

namespace PFW.SchrodersCom.TA.BaseClasses
{

    public abstract class BaseStep
    {



        public string CurrentPageKey
        {
            get { return CurrentPageKey; }
            set { CurrentPageKey = "CurrentPageKey"; }
        }

        public RemoteWebDriver Driver { get; set; }
        public ScenarioContext ScenarioContext { get; }
        public TestConfiguration TestConfiguration { get; }
        public WebDriverSetup WebDriverSetup { get; }


        public BaseStep(ScenarioContext scenarioContext) : base()
        {
            ScenarioContext = scenarioContext;
            TestConfiguration = new TestConfiguration();
            WebDriverSetup = new WebDriverSetup();
        }



        public T CreateANewPage<T>()
        {
            object[] args = new object[] { Driver };
            return (T)Activator.CreateInstance(typeof(T), args);
        }





        public void SaveCurrentPage<T>(T page)
        {
            ScenarioContext.Set(page, CurrentPageKey);
        }


        public T LoadCurrentPage<T>()
        {
            return ScenarioContext.Get<T>(CurrentPageKey);
        }


        public string GetCurrentPageUrl<T>()
        {
           T page = LoadCurrentPage<T>();
           return page.GetType().GetProperty("PageUrl").GetValue(page, null) as string;
        }



        public void NavigateToCurrentPage<T>()
        {
            string url = GetCurrentPageUrl<T>();
            Driver.Navigate().GoToUrl(url);
        }


        public T SetCurrentPageAndNavigateToIt<T>()
        {
            T page = CreateANewPage<T>();
            SaveCurrentPage(page);
            NavigateToCurrentPage<T>();
            return page;
        }

        public T ClickOnWebElementCreatesANewPage<T>(IWebElement webElementOnOldPage)
        {
            webElementOnOldPage.Submit();
            return CreateANewPage<T>();
        }






        public string GetWebElementAttribute(IWebElement webElement, string attributeName)
        {
            return webElement.GetAttribute(attributeName);
        }

        public string[] GetWebElementClasses(IWebElement webElement)
        {
            return GetWebElementAttribute(webElement,"class").Split(' ').Select(x => x.Trim()).ToArray();
        }

        public string[] GetWebElementStyles(IWebElement webElement)
        {
            return GetWebElementAttribute(webElement, "style").Split(';').Select(x => x.Trim()).ToArray();
        }






        public void AssertThatCurrentPageIsLoaded<T>()
        {
            string urlLoaded = Driver.Url;
            string currentPageUrl = GetCurrentPageUrl<T>();
            Assert.AreEqual(urlLoaded, currentPageUrl);
        }

        public void AssertThatExpectedPageIsLoaded<T>(string expectedUrl)
        {
            Assert.AreEqual(expectedUrl, Driver.Url);
        }


        public void AssertThatWebElementIsDisplayed<T>(IWebElement webElement)
        {
            Assert.IsTrue(webElement.Displayed);
        }


        public void AssertThatWebElementIsEnabled<T>(IWebElement webElement)
        {
            Assert.IsTrue(webElement.Enabled);
        }

        public void AssertThatWebElementIsSelected<T>(IWebElement webElement)
        {
            Assert.IsTrue(webElement.Selected);
        }

        public void AssertThatWebElementClassesContains<T>(IWebElement webElement, string expectedClass)
        {
            Assert.IsTrue(GetWebElementClasses(webElement).Contains(expectedClass));
        }

        public void AssertThatWebElementStylesContains<T>(IWebElement webElement, string expectedStyle)
        {
            Assert.IsTrue(GetWebElementClasses(webElement).Contains(expectedStyle));
        }














    }
}
