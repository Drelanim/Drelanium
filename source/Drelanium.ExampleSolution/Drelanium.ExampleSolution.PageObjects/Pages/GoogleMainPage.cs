using System;
using Drelanium.ExampleSolution.PageObjects.Widgets;
using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Drelanium.ExampleSolution.PageObjects.Pages
{
    public class GoogleMainPage : BasePageObject
    {
        public GoogleMainPage([NotNull] IWebDriver driver) : base(driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
        }

        public GoogleFooter GoogleFooter => new GoogleFooter(Driver);

        public IWebElement InputSearchTextbox => PageObjectSearchContext.FindElement(By.Name("q"));

        public IWebElement InputGoogleSearchButton => PageObjectSearchContext.FindElement(By.Name("btnK"));
        public IWebElement InputImFeelingLuckyButton => PageObjectSearchContext.FindElement(By.Name("btnI"));

        public IWebElement ImgGoogleLogo => PageObjectSearchContext.FindElement(By.Id("hplogo"));

        public Uri Url => new Uri("https://www.google.com/");

        public void SearchForContent(string content)
        {
            InputSearchTextbox.SendKeys(content);
            InputGoogleSearchButton.JSClick();
        }
    }
}