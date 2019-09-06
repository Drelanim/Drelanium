using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

// ReSharper disable StringLiteralTypo
// ReSharper disable IdentifierTypo

namespace Drelanium.ExampleSolution.PageObjects.Pages
{
    public class GoogleMainPage : BasePage
    {
        public GoogleMainPage([NotNull] IWebDriver driver) : base(driver)
        {
        }

        public Uri Url => new Uri("https://www.google.com/");

        public By InputSearchTextbox => By.Name("q");

        public By InputGoogleSearchButton => By.Name("btnK");
        public By InputImFeelingLuckyButton => By.Name("btnI");

        public By ImgGoogleLogo => By.Id("hplogo");

        public void SearchForContent(string content)
        {


            throw new NotImplementedException();


        }
    }
}