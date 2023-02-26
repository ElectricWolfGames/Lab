namespace Examples.API
{
    // https://cloud.ibm.com/apidocs/text-to-speech
    // https://cloud.ibm.com/docs/watson?topic=watson-iam

    public partial class TextToSpeech
    {
        private const string _apikey = "<Use token>";
        private const string _baseUrl = @"https://iam.cloud.ibm.com/identity/token";
        private const string _serviceLondon = "https://api.eu-gb.text-to-speech.watson.cloud.ibm.com";

        // Getting started with Speech to Text
        // https://cloud.ibm.com/services/speech-to-text/crn%3Av1%3Abluemix%3Apublic%3Aspeech-to-text%3Aeu-gb%3Aa%2F10c8f61f93184db39e26625d649fc9ea%3Afbb9ab41-99b3-46df-852d-81606e278a78%3A%3A?paneId=gettingStarted&new=true
        //
        // Getting started with Text to Speech
        // https://cloud.ibm.com/services/text-to-speech/crn%3Av1%3Abluemix%3Apublic%3Atext-to-speech%3Aeu-gb%3Aa%2F10c8f61f93184db39e26625d649fc9ea%3A76e53e74-2772-4b43-a02d-5d8800b26f50%3A%3A?paneId=gettingStarted&new=true

        public TextToSpeech()
        {
            var client = new RestSharp.RestClient(_baseUrl);
            var request = new RestSharp.RestRequest();
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            request.AddParameter("grant_type", "urn:ibm:params:oauth:grant-type:apikey");
            request.AddParameter("apikey", _apikey);

            var response = client.Execute(request, RestSharp.Method.POST);

            IBMToken iBMToken = Newtonsoft.Json.JsonConvert.DeserializeObject<IBMToken>(response.Content);

            int i = 0;
            i++;
        }
    }
}