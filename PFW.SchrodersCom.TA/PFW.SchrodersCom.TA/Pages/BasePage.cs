using System;

namespace PFW.SchrodersCom.TA.Pages
{
    public enum TestEnvironment
    {
        SYS1,
        UAT,
        PROD
    }

    public enum PageTypes
    {
        GlobalHome,
        Login
    }



    public abstract class BasePage
    {
        public string UrlPath { get; protected set; }
        public PageTypes PageType { get; protected set; }
        public string Url { get; protected set; }

        private const string SYS1Domain = @"https://sys1.schroders.episerverhosting.com";
        private const string UATDomain = @"https://uat.schroders.episerverhosting.com";
        private const string PRODDomain = @"https://www.schroders.com";

        public BasePage(TestEnvironment environment)
        {
            switch (environment)
            {
                case TestEnvironment.SYS1:
                    this.Url = SYS1Domain + UrlPath;
                    break;
                case TestEnvironment.UAT:
                    this.Url = UATDomain + UrlPath;
                    break;
                case TestEnvironment.PROD:
                    this.Url = PRODDomain + UrlPath;
                    break;
                default:
                    throw new Exception();
            }
        }







    }
}
