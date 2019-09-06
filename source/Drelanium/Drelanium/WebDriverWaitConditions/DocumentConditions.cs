using System;
using System.ComponentModel;
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
        ///     The Document.readyState property should be equal to the given value.
        /// </summary>
        /// <param name="documentReadyState">The Document.readyState property describes the loading state of the document.</param>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, bool> DocumentReadyStateToBe(DocumentReadyState documentReadyState)
        {
            if (!Enum.IsDefined(typeof(DocumentReadyState), documentReadyState))
                throw new InvalidEnumArgumentException(nameof(documentReadyState), (int) documentReadyState,
                    typeof(DocumentReadyState));

            return driver => driver.Document().ReadyState == documentReadyState;
        }
    }
}