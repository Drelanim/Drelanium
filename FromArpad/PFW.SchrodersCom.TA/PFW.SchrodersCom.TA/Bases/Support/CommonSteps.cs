using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gherkin.Ast;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PFW.SchrodersCom.TA.Bases.Support
{
    public static class CommonSteps
    {




        public static T CreateNewPage<T>(BaseStep step)
        {
            object[] args = new object[] { step.Driver };
            return (T)Activator.CreateInstance(typeof(T), args);
        }

        public static T CreateANewPageAndSaveItToCurrentPage<T>(BaseStep step)
        {
            T page = CreateNewPage<T>(step);
            SaveCurrentPage(step,page);
            return page;
        }

        public static T CreateANewPageAndSaveItToCurrentPageAndNavigateTo<T>(BaseStep step)
        {
            T page = CreateANewPageAndSaveItToCurrentPage<T>(step);
            NavigateToCurrentPage<T>(step);
            return page;
        }



        public static void SaveCurrentPage<T>(BaseStep step, T page)
        {
            step.ScenarioContext.Set(page, "CurrentPageKey");
        }


        public static T LoadCurrentPage<T>(BaseStep step)
        {
            return step.ScenarioContext.Get<T>("CurrentPageKey");
        }



        public static string GetCurrentPageUrl<T>(BaseStep step)
        {
            T page = LoadCurrentPage<T>(step);
            return page.GetType().GetProperty("PageUrl").GetValue(page, null) as string;
        }



        public static void NavigateToCurrentPage<T>(BaseStep step)
        {
            string url = GetCurrentPageUrl<T>(step);
            step.Driver.Navigate().GoToUrl(url);
        }

        public static dynamic CreateDynamicTable(Table table)
        {
            return table.CreateDynamicInstance();
            
        }












    }
}
