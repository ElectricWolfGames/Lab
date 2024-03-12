using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Services;

namespace DownloadFiles
{
    public class DownloadFile
    {
        /// <summary>
        /// Download a Document file in PDF format.
        /// </summary>
        /// <param name="fileId">file ID of any workspace document format file.</param>
        /// <returns>byte array stream if successful, null otherwise.</returns>
        public static MemoryStream DriveDownloadFile(string fileId)
        {
            try
            {
                /* Load pre-authorized user credentials from the environment.
                 TODO(developer) - See https://developers.google.com/identity for 
                 guides on implementing OAuth2 for your application. */
                GoogleCredential credential = GoogleCredential
                    .GetApplicationDefault()
                    .CreateScoped(DriveService.Scope.Drive);

                // Create Drive API service.
                var service = new DriveService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(fileId);
                var stream = new MemoryStream();

                // Add a handler which will be notified on progress changes.
                // It will notify on each chunk download and when the
                // download is completed or failed.
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };
                request.Download(stream);

                return stream;
            }
            catch (Exception e)
            {
                // TODO(developer) - handle error appropriately
                if (e is AggregateException)
                {
                    Console.WriteLine("Credential Not found");
                }
                else
                {
                    throw;
                }
            }
            return null;
        }
    }

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