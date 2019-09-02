using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium


{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilDocumentMethods
    {
        /// <summary>
        ///     Waits, until the Document.readyState is equals with the expected value.
        /// </summary>
        /// <param name="expectedDocumentReadyState">The Document.readyState property describes the loading state of the document.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static bool UntilDocumentReadyState(this WebDriverWait wait,
            DocumentReadyState expectedDocumentReadyState)
        {
            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until ({expectedDocumentReadyState.ToString().ToLower()}) document readyState to be ({expectedDocumentReadyState})";

            return wait.Until(WebDriverWaitConditions.DocumentReadyStateToBe(expectedDocumentReadyState));
        }
    }
}