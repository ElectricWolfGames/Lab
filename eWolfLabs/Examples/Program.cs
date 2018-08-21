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

            ShowExpressionTrees();

            Console.ReadKey();
        }

        private static void ShowExpressionTrees()
        {
            ExpressionTrees et = new ExpressionTrees();
            et.ShowTree();
        }

        private static void ShowEmbeddedResources()
        {
            EmbeddedResource.ShouldAllEmbeddedResources();
            Console.WriteLine("Show example embedded resourse file");
            Console.WriteLine(EmbeddedResource.LoadExampleFile());
        }
    }
}