using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Drelanium.ExampleSolution.PageObjects.Widgets
{
    public class GoogleFooter : BasePageObject, IPageWidget
    {
        public GoogleFooter([NotNull] IWebDriver driver) : base(driver, Locator)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
        }

        public static By Locator => By.CssSelector("div.fbar");

        public IWebElement Country => PageObjectSearchContext.FindElement(By.ClassName("b2hzT"));

        public By WidgetLocator => Locator;

        public IWebElement OptionFromLeft(int numberOfOption)
        {
            if (numberOfOption <= 0) throw new ArgumentOutOfRangeException(nameof(numberOfOption));

            return PageObjectSearchContext.FindElements(By.CssSelector("fsl > a"))[numberOfOption - 1];
        }

        public IWebElement OptionFromRight(int numberOfOption)
        {
            if (numberOfOption <= 0) throw new ArgumentOutOfRangeException(nameof(numberOfOption));

            return PageObjectSearchContext.FindElements(By.CssSelector("fsr > a"))[numberOfOption - 1];
        }
    }
}