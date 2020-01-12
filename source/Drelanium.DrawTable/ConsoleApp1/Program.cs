using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{

    public class FluentWait
    {
        public TimeSpan Timeout { get; set; }
        public TimeSpan SleepInterval { get; set; }
        public bool ThrowOnTimeout { get; set; }
        public string TimeoutMessage { get; set; }

        private FluentWait(TimeSpan timeout, TimeSpan sleepInterval, bool throwOnTimeout, string timeoutMessage = "")
        {
            Timeout = timeout;
            SleepInterval = sleepInterval;
            ThrowOnTimeout = throwOnTimeout;
            TimeoutMessage = timeoutMessage;
        }

        public static FluentWait Wait(TimeSpan timeout, TimeSpan sleepInterval, bool throwOnTimeout, string timeoutMessage = "")
        {
            return new FluentWait(timeout, sleepInterval, throwOnTimeout, timeoutMessage);
        }

        public void Until(Func<bool> expectedCondition)  
        {
            var cycleStartTime = DateTime.Now;

            do
            {
                if (expectedCondition())
                {
                    return;
                }
                Thread.Sleep(SleepInterval);
            } while (DateTime.Now - cycleStartTime < Timeout);

            if (ThrowOnTimeout)
            {
                throw new TimeoutException($"Timed out after {Timeout.TotalSeconds} seconds. " + TimeoutMessage);
            }
        }

    }





  public class Program
    {









   public static void Main(string[] args)
        {


            FluentWait.Wait(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(1), true, "Something shit happened")
                .Until(() =>{
                    Console.WriteLine("helloka");
                    return false; 
                });







        }
    }
}
