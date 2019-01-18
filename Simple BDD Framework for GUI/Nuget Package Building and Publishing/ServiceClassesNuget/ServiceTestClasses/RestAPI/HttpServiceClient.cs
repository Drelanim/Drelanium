using System;
using System.Net.Http;


namespace ServiceTestClasses.RestApi
{
    // class that provides a HttpClient object to a given base URL
    // for exercising Web API service calls
    public class HttpServiceClient
    {
        // Http Client  reference
        public HttpClient Client;

        // constructor with default base URL pointing to a Web API
        public HttpServiceClient(string baseUrl)
        {
            try
            {
                // setup HttpClient handler for autocertificate handling
                HttpClientHandler handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Automatic;

                // create client object
                Client = new HttpClient(handler);

                // specify base URI
                Client.BaseAddress = new Uri(baseUrl);
            }
            catch (Exception e)
            {
                throw new Exception("HttpServiceClient : " + e.Message);
            }
        }
    }
}
