using System;
using TechTalk.SpecFlow;

// ReSharper disable IdentifierTypo

namespace Drelanium.ExampleSolution.UITests.StepDefinitions
{
    public class GoogleSearchStepDefinitions : BaseStepDefinition
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
            throw new NotImplementedException();
        }

        [Then(@"the word ""(.*)"" can be found in every search result")]
        public void ThenTheWordCanBeFoundInEverySearchResult(string p0)
        {
            throw new NotImplementedException();
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string p0)
        {
            throw new NotImplementedException();
        }
    }
}