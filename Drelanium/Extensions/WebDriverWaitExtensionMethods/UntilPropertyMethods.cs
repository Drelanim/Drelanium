using System;
using OpenQA.Selenium.Support.UI;


namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{

    /// <summary>To be added...</summary>
    public static class UntilPropertyMethods
    {

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="message">To be added...</param>
        public static WebDriverWait AddTimeoutMessage(this WebDriverWait wait, string message)
        {
            wait.Message = message;
            return wait;
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="pollingInterval">To be added...</param>
        public static WebDriverWait AddPollingInterval(this WebDriverWait wait, TimeSpan pollingInterval)
        {
            wait.PollingInterval = pollingInterval;
            return wait;
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="exceptionTypes">To be added...</param>
        public static WebDriverWait AddIgnoreExceptionTypes(this WebDriverWait wait, params Type[] exceptionTypes)
        {
            wait.IgnoreExceptionTypes(exceptionTypes);
            return wait;
        }

    }

}