using System;
using System.Threading;

namespace Examples
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            // TextToSpeech cf = new TextToSpeech();

            var t = new TestDe();
            t.doThing();

            Thread.Sleep(5000);

            Console.ReadKey();
        }

        /*private static void Main(string[] args)
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
        }*/
    }

    public class TestDe
    {
        public TestDe()
        {
        }

        public void doThing()
        {
            var mc = new MyClass();
        }
    }

    public class MyClass : IDisposable
    {
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Manual release of managed resources.
                }
                // Release unmanaged resources.
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose();
        }

        ~MyClass()
        {
            Dispose(false);
        }
    }
}