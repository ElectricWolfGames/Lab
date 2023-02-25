using LibGit2Sharp;
using System;
using System.Collections.Generic;

namespace GitTools
{
    public class CommitData
    {
        public string Name { get; set; }
        public Signature Author { get; set; }
        public string BranchName { get; set; }

        public List<string> FileNames = new List<string>();

        internal void Display()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Name:" + Name + " by " + Author.Name);
            Console.WriteLine(" at " + Author.When);
        }
    }
}