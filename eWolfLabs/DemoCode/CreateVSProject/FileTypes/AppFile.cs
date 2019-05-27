using CreateVSProject.Holders;
using CreateVSProject.Interfaces;
using System.Text;

namespace CreateVSProject.FileTypes
{
    public class AppFile : IOutputFile
    {
        public ProjectDetailsHolder ProjectDetailsHolder { get; set; }

        public string Output()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
            sb.AppendLine(@"<configuration>");
            sb.AppendLine(@"    <startup> ");
            sb.AppendLine(@"        <supportedRuntime version=""v4.0"" sku="".NETFramework, Version = v4.7.1"" />");
            sb.AppendLine(@"    </startup> ");
            sb.AppendLine(@"</configuration>");

            return sb.ToString();
        }

        public string FileName
        {
            get
            {
                return "App.config";
            }
        }
    }
}
