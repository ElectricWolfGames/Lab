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
            us.Run();
            Console.ReadKey();

            UsingManyStaticsUntestable us2 = new UsingManyStaticsUntestable();
            us2.Run();
            Console.ReadKey();
        }
    }
}