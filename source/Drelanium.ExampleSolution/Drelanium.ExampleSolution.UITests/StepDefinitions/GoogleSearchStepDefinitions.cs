using System;
using Drelanium.BDD;
using Drelanium.ExampleSolution.PageObjects.Pages;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.StepDefinitions
{
    [Binding]
    public class GoogleSearchStepDefinitions : BaseBindingClass
    {
        public GoogleSearchStepDefinitions(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [Given(@"I am visiting Google")]
        public void GivenIAmVisitingGoogle()
        {
            Driver.Navigation().GoToUrl(new Uri("https://www.google.com/"));

            CurrentPage = new GoogleMainPage(Driver);
        }

        [Then(@"the word ""([^\""]*)"" can be found in every search result")]
        public void ThenTheWordCanBeFoundInEverySearchResult(string parameter)
        {
            NotImplementedStepDefinition();
        }

        [When(@"I search for ""([^\""]*)""")]
        public void WhenISearchFor(string parameter)
        {
            ((GoogleMainPage) CurrentPage).SearchForContent(parameter);

            CurrentPage = new GoogleSearchResultsPage(Driver);
        }
    }
}