using System;
using JetBrains.Annotations;
using OpenQA.Selenium;


// ReSharper disable IdentifierTypo

namespace Drelanium.ExampleSolution.PageObjects.Pages
{
    public class GoogleSearchResultsPage : BasePage
    {

        public GoogleSearchResultsPage([NotNull] IWebDriver driver) : base(driver)
        {
        }


    }
}