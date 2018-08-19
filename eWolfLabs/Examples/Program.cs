using Examples.AsyncCode;
using Examples.Reflection;
using System;

namespace Examples
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            // Back ground runner
            //BackGroundTask bgt = new BackGroundTask();
            //bgt.TaskRunner();

            ShowEmbeddedResources();

            Console.ReadKey();
        }

        private static void ShowEmbeddedResources()
        {
            // EmbeddedResource
            EmbeddedResource.ShouldAllEmbeddedResources();
            Console.WriteLine("Show example embedded resourse file");
            Console.WriteLine(EmbeddedResource.LoadExampleFile());
        }
    }
}