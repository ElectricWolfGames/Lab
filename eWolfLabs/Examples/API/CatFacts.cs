using RestSharp;
using System;

namespace Examples.API
{
    public class CatFacts
    {
        private const string baseUrl = @"https://cat-fact.herokuapp.com";

        public CatFacts()
        {
            Console.WriteLine("output");

            RestSharp.RestClient client = new RestSharp.RestClient(baseUrl);
            var request = new RestRequest("facts", Method.POST);
            var response = client.Execute(request);
        }
    }
}