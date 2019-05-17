using Examples.AdvancedCode;
using Examples.BasicCode;
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

            ExecuteCode cb = new ExecuteCode();

            //ShowEmbeddedResources();

            //ShowExpressionTrees();

            PlayerControl pc = new PlayerControl();
            pc.Update();
            pc.Update();

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
