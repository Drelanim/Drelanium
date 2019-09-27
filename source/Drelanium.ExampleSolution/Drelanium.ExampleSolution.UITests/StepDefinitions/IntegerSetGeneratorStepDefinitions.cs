using System;
using Drelanium.BDD;
using Drelanium.ExampleSolution.PageObjects.Pages;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.StepDefinitions
{
    [Binding]
    public class IntegerSetGeneratorStepDefinitions : BaseBindingClass
    {
        public IntegerSetGeneratorStepDefinitions(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [Given(@"I am visiting the Random Org's Random Integer Set Generator page")]
        public void GivenIAmVisitingTheRandomOrgSRandomIntegerSetGeneratorPage()
        {
            NotImplementedStepDefinition();
        }

        [When(
            @"I setup the generator to generate ""(.*)"" sets with ""(.*)"" unique numbers between ""(.*)"" and ""(.*)""")]
        public void WhenISetupTheGeneratorToGenerateSetsWithUniqueNumbersBetweenAnd(int p0, int p1, int p2, int p3)
        {
            NotImplementedStepDefinition();
        }

        [When(@"I click on the Get Sets button")]
        public void WhenIClickOnTheGetSetsButton()
        {
            NotImplementedStepDefinition();
        }

        [Then(@"the number of generated sets is ""(.*)""")]
        public void ThenTheNumberOfGeneratedSetsIs(int p0)
        {
            NotImplementedStepDefinition();
        }

        [Then(@"""(.*)"" error message is displayed")]
        public void ThenErrorMessageIsDisplayed(string p0)
        {
            NotImplementedStepDefinition();
        }
    }
}