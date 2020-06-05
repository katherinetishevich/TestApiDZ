using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ClassLibrary1.Interface 
{
    public interface IGoRestApiClient  
    {
     
        void GetUsers();
        void PostUsers();
    }
}
namespace ClassLibrary1.Interface
{
    public class GoRestApiClient : IGoRestApiClient
    {
        public readonly RestClient Client;

        public GoRestApiClient()
        {
            Client = Client ?? new RestClient();
            Client.BaseUrl = new Uri(ConfigurationManager.AppSettings.Get("GoRestBaseUrl"));
        }
        public IRestResponse GetUsers()
        {
            IRestRequest req = new RestRequest("users");
            req.AddHeader("Autorization", "Bearer 72qUMiLaJhQa0OmioNDq9LDdEcUeYmDVix_v");
            var response = Client.Get(req);
            return response; 
        }

        public void PostUsers()
        {
           // throw new NotImplementedException();
        }

        void IGoRestApiClient.GetUsers()
        {
           // throw new NotImplementedException();
        }
    }

   
}