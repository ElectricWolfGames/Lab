using API_CatFacts.Models;
using RestSharp;

namespace API_CatFacts
{
    public class CatFacts
    {
        public void MakeRequest()
        {
            var client = new RestClient("https://cat-fact.herokuapp.com");
            var request = new RestRequest("/facts");

            RestResponse response = client.Execute(request);
            var root = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Class1>>(response.Content);

            foreach (var fact in root)
            {
                Console.WriteLine(fact.text);
            }
        }
    }
}