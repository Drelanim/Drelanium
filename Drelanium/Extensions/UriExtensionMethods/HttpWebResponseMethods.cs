using System;
using System.Net;


namespace Drelanium.Extensions.UriExtensionMethods
{

    public static class HttpWebResponseMethods
    {

        public static HttpWebResponse HttpWebResponse(this Uri url)
        {
            return (HttpWebResponse) url.HttpWebRequest().GetResponse();
        }

        public static void TestUrlFor404(this Uri url)
        {
            url.HttpWebResponse();
        }

    }

}