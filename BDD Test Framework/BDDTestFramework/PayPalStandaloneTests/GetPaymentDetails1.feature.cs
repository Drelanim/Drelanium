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
namespace PayPalStandaloneTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GetPaymentDetails")]
    public partial class GetPaymentDetailsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GetPaymentDetails.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GetPaymentDetails", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "clientId",
                        "secret"});
            table1.AddRow(new string[] {
                        "default",
                        "default"});
#line 5
 testRunner.Given("get PayPal client credential token with following credentials and OAuth2 results " +
                    "saved as oauth2result", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Payment Details - happy path")]
        [NUnit.Framework.TestCaseAttribute("sale", "paypal", "100.00", "HUF", null)]
        public virtual void GetPaymentDetails_HappyPath(string intent, string payment_Method, string total, string currency, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Payment Details - happy path", null, exampleTags);
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "intent",
                        "return_url",
                        "cancel_url",
                        "payment_method",
                        "total",
                        "currency"});
            table2.AddRow(new string[] {
                        string.Format("{0}", intent),
                        "https://example.com/redirect_url.html",
                        "https://example.com/your_cancel_url.html",
                        string.Format("{0}", payment_Method),
                        string.Format("{0}", total),
                        string.Format("{0}", currency)});
#line 11
 testRunner.When("PayPal payment endpoint is called with token from oauth2result with following con" +
                    "tent and the response payload is saved as paymentResults", ((string)(null)), table2, "When ");
#line 14
 testRunner.Then("http status code in response paymentResults equals 201", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.When("PayPal GEt Payment Details endpoint is called with token from oauth2result with p" +
                    "ayment ID from payment response paymentResults and response saved as paymentDeta" +
                    "ilsResponse", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("http status code in response paymentDetailsResponse equals 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.And("the contents of PayPal Get Payment Details response paymentDetailsResponse matche" +
                    "s the payment details returned from the previous payment call in paymentResults", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
