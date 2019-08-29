﻿using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilDocumentMethods
    {
        /// <summary>
        ///     Waits, until the Document.readyState is equals with the expected value.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="expectedDocumentReadyState">The Document.readyState property describes the loading state of the document.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        public static bool UntilDocumentReadyState(this WebDriverWait wait, string expectedDocumentReadyState,
            Logger logger = null)
        {
            logger?.Information($"Waiting for document's readyState to be equal to ({expectedDocumentReadyState}).");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until ({expectedDocumentReadyState.ToLower()}) document readyState to be ({expectedDocumentReadyState})";
            var result = wait.Until(driver =>
                driver.ExecuteJavaScript<object>("return document.readyState").ToString() ==
                expectedDocumentReadyState);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }
    }
}