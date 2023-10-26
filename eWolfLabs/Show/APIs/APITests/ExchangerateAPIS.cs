using APITests.Model;
using Newtonsoft.Json;

namespace APIs
{
    public class ExchangerateAPIS
    {
        public void MakeRequest()
        {
            // https://www.exchangerate-api.com/docs/c-sharp-currency-api

            string urlString = "https://v6.exchangerate-api.com/v6/641eb1d8406c7917b117c33c/latest/USD";
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(urlString);
                var exchangerateRates = JsonConvert.DeserializeObject<ExchangerateRateRespond>(json);

                Console.WriteLine($"BaseCode: {exchangerateRates.base_code}");
                Console.WriteLine($"GBP: {exchangerateRates.conversion_rates.GBP}");
                Console.WriteLine($"EUR: {exchangerateRates.conversion_rates.EUR}");
            }
        }
    }
}