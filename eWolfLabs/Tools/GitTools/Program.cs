using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using System;
using System.Linq;

namespace GitTools
{
    internal class Program
    {
        private static void Do()
        {
            string logMessage = "";
            using (var repo = new Repository(@"E:\Projects\GitHub\eWolfLabs\eWolfLabs\"))
            {
                Console.WriteLine("here");
                var remote = repo.Network.Remotes["origin"];
                var refSpecs = remote.FetchRefSpecs.Select(x => x.Specification);
                Commands.Fetch(repo, remote.Name, refSpecs, null, logMessage);
            }
            Console.WriteLine(logMessage);
        }

        private static void GetLatest()
        {
            using (var repo = new Repository(@"C:\GitHub\eWolfLabs\"))
            {
                // Credential information to fetch
                PullOptions options = new PullOptions();
                options.FetchOptions = new FetchOptions();
                options.FetchOptions.CredentialsProvider = new CredentialsHandler(
                    (url, usernameFromUrl, types) =>
                        new UsernamePasswordCredentials()
                        {
                            Username = "ElectricWolfGames",
                            Password = "8LpxHHh0LLTrAORQlbJ9"
                        });

                // User information to create a merge commit
                var signature = new LibGit2Sharp.Signature(
                    new Identity("MERGE_USER_NAME", "MERGE_USER_EMAIL"), DateTimeOffset.Now);

                // Pull
                Commands.Pull(repo, signature, options);
            }
        }

        private static void Main(string[] args)
        {
            /*GitHistory gh = new GitHistory(@"C:\GitHub\eWolfLabs\");

            List<CommitData> commits = gh.GetHistory();

            for (int i = 0; i < commits.Count; i++)
            {
                commits[i].Display();
            }*/

            Do();
            GetLatest();
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}