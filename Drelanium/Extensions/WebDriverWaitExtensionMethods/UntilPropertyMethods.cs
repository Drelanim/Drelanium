using System;
using OpenQA.Selenium.Support.UI;


namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{

    public static class UntilPropertyMethods
    {

        public static WebDriverWait AddTimeoutMessage(this WebDriverWait wait, string message)
        {
            wait.Message = message;
            return wait;
        }

        public static WebDriverWait AddPollingInterval(this WebDriverWait wait, TimeSpan pollingInterval)
        {
            wait.PollingInterval = pollingInterval;
            return wait;
        }

        public static WebDriverWait AddIgnoreExceptionTypes(this WebDriverWait wait, params Type[] exceptionTypes)
        {
            wait.IgnoreExceptionTypes(exceptionTypes);
            return wait;
        }

    }

}