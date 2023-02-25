using System;

namespace Calculator
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            AddNumbers an = new AddNumbers();

            an.Run();

            Console.ReadKey();
        }
    }
}