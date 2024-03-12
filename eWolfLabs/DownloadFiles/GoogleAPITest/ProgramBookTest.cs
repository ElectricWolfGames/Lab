using Google.Apis.Auth.OAuth2;
using Google.Apis.Books.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace DownloadFiles
{
    /// <summary>
    /// Sample which demonstrates how to use the Books API.
    /// https://developers.google.com/books/docs/v1/getting_started
    /// <summary>
    /*internal class ProgramBookTest
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Books API Sample: List MyLibrary");
            Console.WriteLine("================================");
            try
            {
                new Program().Run().Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        private async Task Run()
        {
            UserCredential credential;
            
            //ClientSecrets clientSecrets = new ClientSecrets
            //{
            //    ClientId = "ewolfdriveb@driveaccess-381118.iam.gserviceaccount.com",
            //    ClientSecret = "105089919880089752455"
            //};


            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { BooksService.Scope.Books },
                    "user", CancellationToken.None, new FileDataStore("Books.ListMyLibrary"));
            }

            // Create the service.
            var service = new BooksService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Books API Sample",
            });

            var bookshelves = await service.Mylibrary.Bookshelves.List().ExecuteAsync();
            int i = 0;
            i++;
        }
    }*/
}


// create auth
// https://developers.google.com/identity/sign-in/web/sign-in

//Email
//ewolfdriveb@driveaccess-381118.iam.gserviceaccount.com

//Unique ID
//105089919880089752455


// https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-7.0

// https://developers.google.com/products


// follow 
// https://www.c-sharpcorner.com/article/google-oauth-and-calling-rest-api/

// downlioad https://github.com/googleapis/google-api-dotnet-client.git