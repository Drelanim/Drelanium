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


namespace PFW.SchrodersCom.TA.BaseClasses
{

    public class BaseStep
    {

        public string CurrentPageKey => "CurrentPageKey";

        public IWebDriver Driver { get; set; }
        
        public ScenarioContext ScenarioContext;

        public BaseStep(ScenarioContext scenarioContext) => ScenarioContext = scenarioContext;


        public T CreateNewPage<T>()
        {
            object[] args = new object[] { Driver };
            return (T)Activator.CreateInstance(typeof(T), args);
        }

        public T CreateSaveNewPage<T>()
        {
            T page = CreateNewPage<T>();
            SaveCurrentPage(page);
            return page;
        }

        public T CreateSaveNavigateNewPage<T>()
        {
            T page = CreateSaveNewPage<T>();
            NavigateToCurrentPage<T>();
            return page;
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









        public void AssertThatCurrentPageIsLoaded<T>()
        {
            string urlLoaded = Driver.Url;
            string currentPageUrl = GetCurrentPageUrl<T>();
            Assert.AreEqual(urlLoaded, currentPageUrl);
        }

        public void AssertThatExpectedPageIsLoaded(string expectedUrl)
        {
            Assert.AreEqual(expectedUrl, Driver.Url);
        }


        public void AssertThatWebElementIsDisplayed(IWebElement webElement)
        {
            Assert.IsTrue(webElement.Displayed);
        }


        public void AssertThatWebElementIsEnabled(IWebElement webElement)
        {
            Assert.IsTrue(webElement.Enabled);
        }

        public void AssertThatWebElementIsSelected(IWebElement webElement)
        {
            Assert.IsTrue(webElement.Selected);
        }

        public void AssertThatWebElementClassesContains(BasePage page, IWebElement webElement, string expectedClass)
        {
            Assert.IsTrue(page.GetWebElementClasses(webElement).Contains(expectedClass));
        }

        public void AssertThatWebElementStylesContains(BasePage page, IWebElement webElement, string expectedStyle)
        {
            Assert.IsTrue(page.GetWebElementClasses(webElement).Contains(expectedStyle));
        }














    }
}
