using OpenQA.Selenium;

#pragma warning disable 1591

namespace Drelanium.SauceLabs
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public enum SauceJobResult
    {
        Passed,

        Failed
    }


    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class SauceLabsScripts
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">...Description to be added...</param>
        public SauceLabsScripts(IWebDriver driver)
        {
            Driver = driver;
        }


        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>
        private IWebDriver Driver { get; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="text">...Description to be added...</param>
        public void Log(string text)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:context={text}.");
        }


        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="buildName">...Description to be added...</param>
        public void SetJobBuild(string buildName)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-build={buildName}.");
        }


        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="jobInfo">...Description to be added...</param>
        public void SetJobInfo(string jobInfo)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce: job-info={jobInfo}.");
        }


        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="jobName">...Description to be added...</param>
        public void SetJobName(string jobName)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-name={jobName}.");
        }


        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="jobResult">...Description to be added...</param>
        public void SetJobResult(string jobResult)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-result={jobResult}.");
        }


        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="jobResult">...Description to be added...</param>
        public void SetJobResult(SauceJobResult jobResult)
        {
            SetJobResult(jobResult.ToString().ToLower());
        }


        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="tags">...Description to be added...</param>
        public void SetJobTags(string tags)
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-tags={tags}.");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void SetSauceBreakPoint()
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript("sauce: break.");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void StartNetwork()
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript("sauce: start network.");
        }


        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void StopNetwork()
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript("sauce: stop network.");
        }
    }
}