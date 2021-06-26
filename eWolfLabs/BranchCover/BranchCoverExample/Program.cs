using System;

namespace BranchCoverExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LineCovered lc = new LineCovered();
            var d = lc.DoStuff("c");

            Console.WriteLine(d.Value);
        }
    }
}