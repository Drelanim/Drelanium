﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PlanetWinE2ETests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AccountData")]
    public partial class AccountDataFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AccountData.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AccountData", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("access the acount data page on specified browser in italian")]
        [NUnit.Framework.TestCaseAttribute("CHROME", null)]
        [NUnit.Framework.TestCaseAttribute("FIREFOX", null)]
        [NUnit.Framework.TestCaseAttribute("EDGE", null)]
        public virtual void AccessTheAcountDataPageOnSpecifiedBrowserInItalian(string browser, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("access the acount data page on specified browser in italian", null, exampleTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given(string.Format("Browser type is {0}", browser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Given("login to PlanetWin with default user credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.When("logged in and selecting the account data tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.Then("verify username on account data tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("access the acount data page on specified browser and language")]
        [NUnit.Framework.TestCaseAttribute("CHROME", "Italiano", null)]
        [NUnit.Framework.TestCaseAttribute("FIREFOX", "English", null)]
        [NUnit.Framework.TestCaseAttribute("EDGE", "Deutsch", null)]
        [NUnit.Framework.TestCaseAttribute("CHROME", "Français", null)]
        [NUnit.Framework.TestCaseAttribute("FIREFOX", "Argentina", null)]
        [NUnit.Framework.TestCaseAttribute("EDGE", "Balkans", null)]
        [NUnit.Framework.TestCaseAttribute("CHROME", "Български", null)]
        [NUnit.Framework.TestCaseAttribute("FIREFOX", "Polski", null)]
        [NUnit.Framework.TestCaseAttribute("EDGE", "Română", null)]
        [NUnit.Framework.TestCaseAttribute("CHROME", "Shqip", null)]
        [NUnit.Framework.TestCaseAttribute("FIREFOX", "Österreich", null)]
        [NUnit.Framework.TestCaseAttribute("EDGE", "Chinese", null)]
        [NUnit.Framework.TestCaseAttribute("CHROME", "Turkish", null)]
        public virtual void AccessTheAcountDataPageOnSpecifiedBrowserAndLanguage(string browser, string language, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("access the acount data page on specified browser and language", null, exampleTags);
#line 16
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 17
 testRunner.Given(string.Format("Browser type is {0}", browser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "username",
                        "password",
                        "language"});
            table1.AddRow(new string[] {
                        "EPAM_QA_BUD_24",
                        "Arpito",
                        string.Format("{0}", language)});
#line 18
 testRunner.Given("login to PlanetWin with following data", ((string)(null)), table1, "Given ");
#line 21
 testRunner.When("logged in and selecting the account data tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("verify username on account data tab against username EPAM_QA_BUD_24", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
