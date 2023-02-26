using CreateVSProject.Holders;
using CreateVSProject.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace CreateVSProject.FileTypes
{
    public class PackagesFile : IOutputFile
    {
        public List<string> Files = new List<string>();

        public string FileName
        {
            get
            {
                return "packages.config";
            }
        }

        public ProjectDetailsHolder ProjectDetailsHolder { get; set; }

        public string Output()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
            sb.AppendLine(@"<packages>");
            foreach (string line in Files)
            {
                sb.AppendLine(line);
            }
            sb.AppendLine(@"</packages>");

            return sb.ToString();
        }
    }
}