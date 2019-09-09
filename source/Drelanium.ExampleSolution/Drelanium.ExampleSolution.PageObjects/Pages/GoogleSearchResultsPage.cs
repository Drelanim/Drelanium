using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

// ReSharper disable IdentifierTypo

namespace Drelanium.ExampleSolution.PageObjects.Pages
{
    public class GoogleSearchResultsPage : BasePageObject, IPage
    {
        public GoogleSearchResultsPage([NotNull] IWebDriver driver) : base(driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
        }

        public Uri Url => new Uri("https://www.google.com/");
    }
}