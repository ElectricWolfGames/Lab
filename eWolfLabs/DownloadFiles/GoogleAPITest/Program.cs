namespace DownloadFiles
{

    // new example https://developers.google.com/drive/api/guides/manage-downloads#.net
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://docs.google.com/spreadsheets/d/1t0-_Eb1Ow7mqiOIIFWEd7VH1kYoagsHXEeOiqP4AsIY/edit#gid=1816705912
            string docId = "1t0-_Eb1Ow7mqiOIIFWEd7VH1kYoagsHXEeOiqP4AsIY/edit#gid=1816705912";
            DownloadFile.DriveDownloadFile(docId);

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