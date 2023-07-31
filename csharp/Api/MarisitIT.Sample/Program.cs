using System;
using System.Linq;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace MarisitIT.Sample
{
    internal class Program
    {
        private const string Username = "";
        private const string Password = "";
        
        // or when live "https://online.marisit.co.za"
        private const string ApiBasePath = "https://uat.marisit.co.za";

        private static Configuration AuthConfig(string token)
        {
            var config = new Configuration
            {
                BasePath = ApiBasePath
            };

            // token is a primitive returned from the API
            // is json encoded and therefore needs to be deserialized. For now just strip the quotes
            config.ApiKey.Add("Authorization", token.Substring(1, token.Length - 2));
            config.ApiKeyPrefix.Add("Authorization", "Bearer");
            return config;
        }

        public static void Main(string[] args)
        {
            // first step is to authenticate
            // token is valid for 24 hours from generation
            var authenticationApi = new AuthenticationApi(ApiBasePath);
            var token = authenticationApi.Login(new LoginRequest(Username, Password));

            // then instantiate any API using then AuthConfig method
            // which will inject the token using Bearer authentication

            var xdsApi = new XdsConsumerIndividualApi(AuthConfig(token));
            var list = xdsApi.XdsIdTrace(new XdsTraceIdRequest("6002100560184"));

            if (!list.Success)
            {
                Console.WriteLine("No results found");
                return;
            }

            var reference = list.Data.First().Reference;
            var result = xdsApi.XdsTraceResult(new ReferenceBonusRequest(reference, null));

            Console.WriteLine(result.Data.ConsumerDetail.FirstName);
            Console.WriteLine(result.Data.ConsumerDetail.Surname);
        }
    }
}