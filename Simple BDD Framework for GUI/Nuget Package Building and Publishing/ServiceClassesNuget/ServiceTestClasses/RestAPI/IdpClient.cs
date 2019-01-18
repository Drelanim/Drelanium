using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IdentityModel.Client;

namespace ServiceTestClasses.RestApi
{
    public class IdpClient
    {
        public OAuth2Client OAuth2Client { get; set; }

        public IdpClient(string idpUrl, string clientId, string secret)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            OAuth2Client = new OAuth2Client(new Uri(idpUrl), clientId, secret);
        }
        public TokenResponse GetClientCredentialsToken()
        {         
            return  OAuth2Client.RequestClientCredentialsAsync().Result;
        }
    }
}
