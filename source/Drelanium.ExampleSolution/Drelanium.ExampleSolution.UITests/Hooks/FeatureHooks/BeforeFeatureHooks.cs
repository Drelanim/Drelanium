using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
{
    public class BeforeFeatureHooks : BaseBindingClass
    {
        public BeforeFeatureHooks(
               TestThreadContext testThreadContext,
               FeatureContext featureContext,
               ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }





        [BeforeFeature(Order = 1)]
        public static void BeforeFeature1(
         TestThreadContext testThreadContext,
            FeatureContext featureContext)
        {

            var driver = DriverInitializer.StartWebDriver(
                ExecutionMode.LOCAL,
                BrowserType.CHROME,
                new ChromeOptions(),
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            testThreadContext.Set(driver);


        }











    }
}
