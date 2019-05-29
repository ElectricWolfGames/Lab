using System.Collections.Generic;

namespace CreateVSProject.Builders.Settings
{


    public static class SonarQubeSettings
    {
        private static readonly string SonarVerson = "7.14.0.8411";

        public static List<string> GetPackageLines()
        {
            List<string> items = new List<string>();
            items.Add($@"  <package id=""SonarAnalyzer.CSharp"" version=""{SonarVerson}"" targetFramework=""net471"" developmentDependency=""true"" />");
            return items;
        }
    }
    

}