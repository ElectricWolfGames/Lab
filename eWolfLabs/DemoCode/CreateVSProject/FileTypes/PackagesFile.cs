using CreateVSProject.Holders;
using CreateVSProject.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace CreateVSProject.FileTypes
{
    public class PackagesFile : IOutputFile
    {
        public ProjectDetailsHolder ProjectDetailsHolder { get; set; }

        public List<string> Files = new List<string>();

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

        public string FileName
        {
            get
            {
                return "packages.config";
            }
        }
    }
}