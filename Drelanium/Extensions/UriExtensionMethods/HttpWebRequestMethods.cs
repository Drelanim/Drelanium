using System;
using System.Net;


namespace Drelanium.Extensions.UriExtensionMethods
{

    public static class HttpWebRequestMethods
    {

        public static HttpWebRequest HttpWebRequest(this Uri url)
        {
            return (HttpWebRequest) WebRequest.Create(url);
        }

    }

}