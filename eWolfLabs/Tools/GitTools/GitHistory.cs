using LibGit2Sharp;
using System.Collections.Generic;
using System.Linq;

namespace GitTools
{
    public class GitHistory
    {
        private Repository _repository;

        public GitHistory(string repositoryName)
        {
            _repository = new Repository(repositoryName);
        }

        public List<CommitData> GetHistory()
        {
            int total = 100;
            List<CommitData> commits = new List<CommitData>();
            List<Branch> allBranches = _repository.Branches.ToList();
            foreach (Branch b in allBranches)
            {
                foreach (Commit c in b.Commits)
                {
                    CommitData comitData = new CommitData();
                    // comitData.DateTime = c.
                    comitData.BranchName = b.FriendlyName;
                    comitData.Name = c.Message;
                    List<string> filenames = new List<string>();

                    foreach (var tr in c.Tree)
                    {
                        filenames.Add(tr.Name);
                    }
                    comitData.Author = c.Author;
                    comitData.FileNames = filenames;

                    commits.Add(comitData);
                    if (total-- < 0)
                        break;
                }
            }
            return commits;
        }
    }
}
