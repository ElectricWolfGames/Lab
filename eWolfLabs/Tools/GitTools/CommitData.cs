using LibGit2Sharp;
using System;
using System.Collections.Generic;

namespace GitTools
{
    public class CommitData
    {
        public List<string> FileNames = new List<string>();
        public Signature Author { get; set; }
        public string BranchName { get; set; }
        public string Name { get; set; }

        internal void Display()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Name:" + Name + " by " + Author.Name);
            Console.WriteLine(" at " + Author.When);
        }
    }
}