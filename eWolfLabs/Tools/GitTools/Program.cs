using System;
using System.Collections.Generic;

namespace GitTools
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GitHistory gh = new GitHistory(@"C:\GitHub\eWolfLabs\");

            List<CommitData> commits = gh.GetHistory();

            for (int i = 0; i < commits.Count; i++)
            {
                commits[i].Display();
            }

            Console.ReadKey();
        }
    }
}
