using System.Collections.Generic;

namespace CreateVSProject.Builders.Settings
{
    public static class FluentAssertionsSettings
    {
        private static readonly string FluentAssertionsVersion = "5.5.1";

        public static List<string> GetPackageLines()
        {
            List<string> items = new List<string>();
            items.Add(@"  <package id=""FluentAssertions"" version=""FluentAssertionsVersion"" targetFramework=""net461"" />");
            return items;
        }
    }
    

}