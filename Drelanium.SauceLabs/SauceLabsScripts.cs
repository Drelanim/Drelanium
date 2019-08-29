using OpenQA.Selenium;

#pragma warning disable 1591

namespace Drelanium.SauceLabs
{
    /// <summary>
    ///     To be added...
    /// </summary>
    public enum SauceJobResult
    {
        Passed,

        Failed
    }


    /// <summary>
    ///     To be added...
    /// </summary>
    public class SauceLabsScripts
    {
        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">To be added...</param>
        public SauceLabsScripts(IWebDriver driver)
        {
            Driver = driver;
        }

        private IWebDriver Driver { get; }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="text">To be added...</param>
        public void Log(string text)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:context={text}.");
        }


        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="buildName">To be added...</param>
        public void SetJobBuild(string buildName)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-build={buildName}.");
        }


        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="jobInfo">To be added...</param>
        public void SetJobInfo(string jobInfo)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce: job-info={jobInfo}.");
        }


        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="jobName">To be added...</param>
        public void SetJobName(string jobName)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-name={jobName}.");
        }


        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="jobResult">To be added...</param>
        public void SetJobResult(string jobResult)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-result={jobResult}.");
        }


        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="jobResult">To be added...</param>
        public void SetJobResult(SauceJobResult jobResult)
        {
            SetJobResult(jobResult.ToString().ToLower());
        }


        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="tags">To be added...</param>
        public void SetJobTags(string tags)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-tags={tags}.");
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public void SetSauceBreakPoint()
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript("sauce: break.");
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public void StartNetwork()
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript("sauce: start network.");
        }


        /// <summary>
        ///     To be added...
        /// </summary>
        public void StopNetwork()
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript("sauce: stop network.");
        }
    }
}