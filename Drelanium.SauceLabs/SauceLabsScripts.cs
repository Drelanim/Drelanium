using OpenQA.Selenium;

#pragma warning disable 1591

namespace Drelanium.SauceLabs
{
    /// <summary>
    /// </summary>
    public enum SauceJobResult
    {
        Passed,

        Failed
    }


    /// <summary>
    /// </summary>
    public class SauceLabsScripts
    {
        /// <summary>
        /// </summary>
        /// <param name="driver"></param>
        public SauceLabsScripts(IWebDriver driver)
        {
            Driver = driver;
        }

        private IWebDriver Driver { get; }


        /// <summary>
        /// </summary>
        /// <param name="text"></param>
        public void Log(string text)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:context={text}");
        }


        /// <summary>
        /// </summary>
        /// <param name="buildName"></param>
        public void SetJobBuild(string buildName)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-build={buildName}");
        }


        /// <summary>
        /// </summary>
        /// <param name="jobInfo"></param>
        public void SetJobInfo(string jobInfo)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce: job-info={jobInfo}");
        }


        /// <summary>
        /// </summary>
        /// <param name="jobName"></param>
        public void SetJobName(string jobName)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-name={jobName}");
        }


        /// <summary>
        /// </summary>
        /// <param name="jobResult"></param>
        public void SetJobResult(string jobResult)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-result={jobResult}");
        }


        /// <summary>
        /// </summary>
        /// <param name="jobResult"></param>
        public void SetJobResult(SauceJobResult jobResult)
        {
            SetJobResult(jobResult.ToString().ToLower());
        }


        /// <summary>
        /// </summary>
        /// <param name="tags"></param>
        public void SetJobTags(string tags)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-tags={tags}");
        }

        /// <summary>
        /// </summary>
        public void SetSauceBreakPoint()
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript("sauce: break");
        }


        /// <summary>
        /// </summary>
        public void StartNetwork()
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript("sauce: start network");
        }


        /// <summary>
        /// </summary>
        public void StopNetwork()
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript("sauce: stop network");
        }
    }
}