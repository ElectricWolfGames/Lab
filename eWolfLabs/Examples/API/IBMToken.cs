﻿namespace Examples.API
{
    public partial class TextToSpeech
    {
        public class IBMToken
        {
            public string access_token { get; set; }
            public string refresh_token { get; set; }
            public string token_type { get; set; }

            public string expires_in { get; set; }

            public string expiration { get; set; }
        }
    }
}