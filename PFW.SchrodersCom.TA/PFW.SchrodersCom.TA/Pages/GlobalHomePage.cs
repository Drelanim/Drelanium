using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;




namespace PFW.SchrodersCom.TA.Pages
{
    class GlobalHomePage : BasePage
    {
        private string _urlPath = "";
        private PageTypes _pageType = PageTypes.GlobalHome;

        public GlobalHomePage(TestEnvironment environment): base(environment)
        {
            this.PageType = _pageType;
            this.UrlPath = _urlPath;
        }



        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }







    }
}
