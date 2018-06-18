using System;
using UntestableCode.Testable;
using UntestableCode.Untestable;

namespace UntestableCode
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            UsingStaticsTestable us = new UsingStaticsTestable();
            //UsingManyStaticsUntestable us = new UsingManyStaticsUntestable();
            us.Run();

            Console.ReadKey();
        }
    }
}
