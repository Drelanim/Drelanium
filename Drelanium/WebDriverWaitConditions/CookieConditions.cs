using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium
{
    /// <summary>
    ///     Collection of methods, that provides exit condition for the <see cref="WebDriverWait" /> type's Until(
    ///     <see cref="Func{T,TResult}" />) method.
    /// </summary>
    public static partial class WebDriverWaitConditions
    {
        /// <summary>
        ///     The browser's cookies meet the condition.
        /// </summary>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static Func<IWebDriver, TResult> Cookies<TResult>(Func<ReadOnlyCollection<Cookie>, TResult> condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(driver.Manage().Cookies.AllCookies);
        }
    }
}