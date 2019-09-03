using System;
using JetBrains.Annotations;
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
        public SauceLabsScripts([NotNull] IWebDriver driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>
        private IWebDriver Driver { get; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="text">...Description to be added...</param>
        public void Log([NotNull] string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));

            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:context={text}");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="buildName">...Description to be added...</param>
        public void SetJobBuild([NotNull] string buildName)
        {
            if (buildName == null) throw new ArgumentNullException(nameof(buildName));

            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-build={buildName}");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="jobInfo">...Description to be added...</param>
        public void SetJobInfo([NotNull] string jobInfo)
        {
            if (jobInfo == null) throw new ArgumentNullException(nameof(jobInfo));

            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce: job-info={jobInfo}");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="jobName">...Description to be added...</param>
        public void SetJobName([NotNull] string jobName)
        {
            if (jobName == null) throw new ArgumentNullException(nameof(jobName));

            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-name={jobName}");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="jobResult">...Description to be added...</param>
        public void SetJobResult([NotNull] string jobResult)
        {
            if (jobResult == null) throw new ArgumentNullException(nameof(jobResult));

            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-result={jobResult}");
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
        public void SetJobTags([NotNull] string tags)
        {
            if (tags == null) throw new ArgumentNullException(nameof(tags));

            ((IJavaScriptExecutor) Driver).ExecuteScript($"sauce:job-tags={tags}");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void SetSauceBreakPoint()
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript("sauce: break");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void StartNetwork()
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript("sauce: start network");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void StopNetwork()
        {
            ((IJavaScriptExecutor) Driver).ExecuteScript("sauce: stop network");
        }
    }
}