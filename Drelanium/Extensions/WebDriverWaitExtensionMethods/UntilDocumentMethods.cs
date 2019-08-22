using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;

namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{
    /// <summary>To be added...</summary>
    public static class UntilDocumentMethods
    {
        /// <summary>To be added...</summary>
        /// <param name="documentReadyState">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        public static bool UntilDocumentReadyState(this WebDriverWait wait, string documentReadyState,
            Logger logger = null)
        {
            logger?.Information($"Waiting for document's readyState to be equal to ({documentReadyState})");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until ({documentReadyState.ToLower()}) document readyState to be {documentReadyState}";
            var result = wait.Until(driver =>
                driver.ExecuteJavaScript<object>("return document.readyState").ToString() == documentReadyState);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }
    }
}