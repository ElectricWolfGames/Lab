using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
