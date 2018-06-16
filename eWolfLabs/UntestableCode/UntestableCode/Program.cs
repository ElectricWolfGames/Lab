using System;
using UntestableCode.Testable;

namespace UntestableCode
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            UsingStaticsTestable us = new UsingStaticsTestable();
            us.Run();

            Console.ReadKey();
        }
    }
}
