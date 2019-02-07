using System;
using System.Collections.Generic;

namespace GitTools
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GitHistory gh = new GitHistory(@"C:\GitHub\Labs\Labs");
            List<CommitData> commits = gh.GetHistory();

            for (int i = 0; i < commits.Count; i++)
            {
                commits[i].Display();
            }

            Console.ReadKey();
        }
    }
}
