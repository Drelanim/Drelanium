using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using ServiceTestClasses.RestApi;
using TechTalk.SpecFlow;
using Thinktecture.IdentityModel.Client;

namespace ServiceTestClasses
{
    public class RestClient : HttpServiceClient
    {
        public HttpClient Client { get; set; }

        public RestClient(string baseUrl)
            : base(baseUrl)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            Client = new HttpServiceClient(baseUrl).Client;
        }

        public Dictionary<string, object> PostRequest(string urlResource, string accessToken, object requestPayload)
        {
            // add authorization and X-Correlation-Token to request headers
            Client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

            // create jason post body
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string postBody = serializer.Serialize(requestPayload);
            Console.WriteLine("json post body = " + postBody);

            // issue webApi call 
            HttpResponseMessage httpResponse = Client.PostAsync(urlResource, new StringContent(postBody, Encoding.UTF8, "application/json")).Result;

            // save http response in context
            ScenarioContext.Current.Set(httpResponse, "HttpResponse");
            string resultJson = httpResponse.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"return HTTP status code = {httpResponse.StatusCode} {(int)httpResponse.StatusCode}");

            // process returned result JSON
            Console.WriteLine("returned result JSON = " + resultJson);
            var result = (Dictionary<string, object>)serializer.Deserialize<object>(resultJson);
            return result;
        }

        public Dictionary<string, object> GetRequestBasic(string urlResource, string accessToken)
        {
            // add authorization and X-Correlation-Token to request headers
            Client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

            // issue webApi call 
            HttpResponseMessage httpResponse = Client.GetAsync(urlResource).Result;
 
            // save http response in context
            ScenarioContext.Current.Set(httpResponse, "HttpResponse");
            string resultJson = httpResponse.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"return HTTP status code = {httpResponse.StatusCode} {(int)httpResponse.StatusCode}");

            // process returned result JSON
            Console.WriteLine("returned result JSON = " + resultJson);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var result = (Dictionary<string, object>)serializer.Deserialize<object>(resultJson);
            return result;
        }
    }
}
