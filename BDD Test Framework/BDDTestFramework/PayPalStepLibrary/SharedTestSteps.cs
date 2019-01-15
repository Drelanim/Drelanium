using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using ServiceWrappers.RestApi;
using TestCommon;
using Thinktecture.IdentityModel.Client;
using Z_PayPalStepLibrary.contracts;

namespace Z_PayPalStepLibrary
{
    [Binding]
    public class SharedTestSteps: CommonStepMethods
    {
        public SharedTestSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [When(@"get PayPal client credential token with following credentials and OAuth2 results saved as (.*)")]
        [Given(@"get PayPal client credential token with following credentials and OAuth2 results saved as (.*)")]
        public void WhenGetPayPalClientCredentialTokenWithFollowingCredentialsAndOAouthResultsSavedAs(string oauth2Key, Table table)
        {
            // prepare parameters needed for idp OAuth2 call
            string clientId = null;
            string secret = null;
            table.Rows.FirstOrDefault().TryGetValue("clientId", out clientId);
            if (clientId == "default")
            {
                clientId = ConfigurationManager.AppSettings["PayPalClientId"];
            }
            table.Rows.FirstOrDefault().TryGetValue("secret", out secret);
            if (secret == "default")
            {
                secret = ConfigurationManager.AppSettings["PayPalSecret"];
            }
            string idpUrl = ConfigurationManager.AppSettings["PayPalIdpUrl"];

            // call the IDP
            var idpCLient = new IdpClient(idpUrl, clientId, secret);
            var oauthresult = idpCLient.GetClientCredentialsToken();
            scenarioContext.Set(oauthresult, oauth2Key);
        }

        [Then(@"the token returned in OAuth2 results (.*) is valid")]
        public void ThenTheTokenReturnedInOAuthResultsIsValid(string oauth2Key)
        {
            var oauthresult = scenarioContext.Get<TokenResponse>(oauth2Key);
            Console.WriteLine("token = " + oauthresult.AccessToken);
            Console.WriteLine("token type = " + oauthresult.TokenType);
            Console.WriteLine("expires in = " + oauthresult.ExpiresIn);
            Console.WriteLine("error reason = " + oauthresult.HttpErrorReason);
            Assert.False(oauthresult.IsHttpError, "failed to obtain token drom IDP");
        }

        [Then(@"the OAuth2 results (.*) contains HttpErrorReason (.*)")]
        public void ThenTheOAuthResultsContainsHttpErrorReasonUnathorized(string oauth2Key, string httpErrorReason)
        {
            var oauthresult = scenarioContext.Get<TokenResponse>(oauth2Key);
            Assert.True(oauthresult.IsHttpError, "unexpected oauthresult.IsHttpError value");
            Assert.AreEqual(httpErrorReason, oauthresult.HttpErrorReason, "unexpected oauthresult.HttpErrorReason");
        }

        [When(@"PayPal payment endpoint is called with token from (.*) with following content and the response payload is saved as (.*)")]
        public void WhenPayPalPaymentEndpointIsCalledWithTkenFromAndTheFollowingContentAndResultsPayloadSavedAs(string oauth2Key, string resultsPayloadKey, PaymentRequest paymentRequest)
        {
            // load token response and PayPalBase URL
            var oauthresult = scenarioContext.Get<TokenResponse>(oauth2Key);
            string serviceUrl = ConfigurationManager.AppSettings["PayPalBaseUrl"] + "payments/payment";

            // create REST client
            var restClient = new RestClient(serviceUrl);

            // post request 
            var result = restClient.PostRequest(String.Empty, oauthresult.AccessToken, paymentRequest);

            // save response dictionary in context 
            scenarioContext.Set(result, HttpResponseDictionaryKey);
            scenarioContext.Set(result, resultsPayloadKey);

            // quit rest client
            restClient.Client.Dispose();
        }

        [When(@"PayPal GEt Payment Details endpoint is called with token from (.*) with payment ID from payment response (.*) and response saved as (.*)")]
        public void WhenPayPalGEtPaymentDetailsEndpointIsCalledWithTokenFromAndWithPaymentIDFromPreviousPaymentResponse(string oauth2Key, string resultsPayloadKey, string resultsSaveKey)
        {
            var oauthresult =scenarioContext.Get<TokenResponse>(oauth2Key);
            var resultsPayload = scenarioContext.Get<Dictionary<string, object>>(resultsPayloadKey);

            // get payment id from previous payment results
            var paymentId = (string)resultsPayload["id"];
            string serviceUrl = ConfigurationManager.AppSettings["PayPalBaseUrl"] + "payments/payment/";

            // create REST client
            var restClient = new RestClient(serviceUrl);

            // post request 
            var result = restClient.GetRequestBasic(paymentId, oauthresult.AccessToken);

            // save response dictionary in context 
            scenarioContext.Set(result, resultsSaveKey);
        }

        [Then(@"the contents of PayPal Get Payment Details response (.*) matches the payment details returned from the previous payment call in (.*)")]
        public void ThenTheContentsOfPayPalGetPaymentDetailsResponseMatchesThePaymentDetailsReturnedFromThePreviousPaymentCallIn(string paymentDetailsResponseKey, string paymentResponseKey)
        {
            var paymentDetailsResponse = scenarioContext.Get<Dictionary<string, object>>(paymentDetailsResponseKey);
            var paymentResponse = scenarioContext.Get<Dictionary<string, object>>(paymentResponseKey);

            // extract payment particulars from payment response
            var expectedIntent = paymentResponse["intent"];
            string expectedPayentMethod = null;
            string expectedTotal = null;
            string expectedCurrency = null;
            var expectedPayerArray = (ICollection)paymentResponse["payer"];
            foreach (KeyValuePair<string, object> item in expectedPayerArray)
            {
                expectedPayentMethod = (string)item.Value;
            }
            var expectedTransactionsArray = (ICollection)paymentResponse["transactions"];
            foreach (ICollection transaction in expectedTransactionsArray)
            {
                foreach (KeyValuePair<string, object> item in transaction)
                {
                    try
                    {
                        expectedTotal = (string)((Dictionary<string, object>)item.Value)["total"];
                        expectedCurrency = (string)((Dictionary<string, object>)item.Value)["currency"];
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            // extract payment particulars from payment details response, note there is no payment method in these responses
            var actualIntent = paymentResponse["intent"];
            string actualTotal = null;
            string actualCurrency = null;
            var actualTransactionsArray = (ICollection)paymentDetailsResponse["transactions"];
            foreach (ICollection transaction in actualTransactionsArray)
            {
                foreach (KeyValuePair<string, object> item in transaction)
                {
                    try
                    {
                        actualTotal = (string)((Dictionary<string, object>)item.Value)["total"];
                        actualCurrency = (string)((Dictionary<string, object>)item.Value)["currency"];
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            // assert payment parameters
            Assert.AreEqual(expectedTotal, actualTotal, "total amount mismatch");
            Assert.AreEqual(expectedCurrency, actualCurrency, "currency mismatch");
            Assert.AreEqual(expectedIntent, actualIntent, "intent mismatch");
        }

        [Then(@"the error message in the results payload (.*) equals (.*)")]
        public void ThenTheErrorMessageInTheResultsPayloadEquals(string resultsPayloadKey, string errorMessage)
        {
            var resultsPayload = scenarioContext.Get<Dictionary<string, object>>(resultsPayloadKey);
            var detailsDictArray = ((object[])resultsPayload["details"]);
            Assert.AreEqual(1, detailsDictArray.Length, "unexpected error count in PayPal response");
            var issue = ((Dictionary<string, object>)detailsDictArray[0])["issue"];
            Assert.AreEqual(errorMessage, issue, "unexpected error message in PayPal response");
        }
    }
}
