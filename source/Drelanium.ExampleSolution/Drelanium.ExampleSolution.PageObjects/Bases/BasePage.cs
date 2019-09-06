using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

// ReSharper disable IdentifierTypo

namespace Drelanium.ExampleSolution.PageObjects
{
    public abstract class BasePage
    {
        protected BasePage([NotNull] IWebDriver driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        public IWebDriver Driver { get; }
    }
}