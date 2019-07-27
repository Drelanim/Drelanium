using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;


namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{

    public static class UntilDocumentMethods
    {

        public static bool UntilDocumentReadyState(this WebDriverWait wait, string documentReadyState)
        {
            wait.Message += $"Waited until ({documentReadyState.ToLower()}) document readyState to be {documentReadyState}";
            return wait.Until(driver => driver.ExecuteJavaScript<object>("return document.readyState").ToString() == documentReadyState);
        }

    }

}