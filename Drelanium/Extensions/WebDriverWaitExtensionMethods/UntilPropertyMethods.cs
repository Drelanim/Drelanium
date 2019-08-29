using System;
using OpenQA.Selenium.Support.UI;

namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilPropertyMethods
    {
        /// <summary>
        ///     Adding IgnoreExceptionTypes to the <see cref="WebDriverWait" /> instance.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="exceptionTypes">
        ///     Configures this instance to ignore specific types of exceptions while waiting for a condition.
        ///     Any exceptions not whitelisted will be allowed to propagate, terminating the wait.
        /// </param>
        public static WebDriverWait AddIgnoreExceptionTypes(this WebDriverWait wait, params Type[] exceptionTypes)
        {
            wait.IgnoreExceptionTypes(exceptionTypes);
            return wait;
        }


        /// <summary>
        ///     Adding AddPollingInterval to the <see cref="WebDriverWait" /> instance.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="pollingInterval">How often the condition should be evaluated. The default timeout is 500 milliseconds.</param>
        public static WebDriverWait AddPollingInterval(this WebDriverWait wait, TimeSpan pollingInterval)
        {
            wait.PollingInterval = pollingInterval;
            return wait;
        }


        /// <summary>
        ///     Adding AddTimeoutMessage to the <see cref="WebDriverWait" /> instance.
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="message">The message to be displayed when time expires.</param>
        public static WebDriverWait AddTimeoutMessage(this WebDriverWait wait, string message)
        {
            wait.Message = message;
            return wait;
        }
    }
}