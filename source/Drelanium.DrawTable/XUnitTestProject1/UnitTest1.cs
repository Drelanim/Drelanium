using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System.Threading;

using OpenQA.Selenium.Support;
using ClassLibrary;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            IWebDriver driver = new ChromeDriver(path);

            driver.Navigate().GoToUrl("https://www.google.com/");
            var googlePage = new GooglePage(driver);


            var element = googlePage.Logo2;

            


            driver.Quit();


        }
    }
}
