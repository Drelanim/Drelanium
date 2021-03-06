﻿using TechTalk.SpecFlow;
using XUnitTestProject.BaseClasses;

namespace XUnitTestProject
{
    [Binding]
    public sealed class StepDefinition1 : BaseStepDefinition
    {
        public StepDefinition1(TestThreadContext testThreadContext, FeatureContext featureContext,
            ScenarioContext scenarioContext) : base(testThreadContext, featureContext, scenarioContext)
        {
        }
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            NotImplementedStepDefinition();

            ScenarioContext.Pending();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            ScenarioContext.Pending();
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            //TODO: implement act (action) logic

            ScenarioContext.Pending();
        }
    }
}