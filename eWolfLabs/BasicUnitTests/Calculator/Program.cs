using System;

namespace Calculator
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            AddNumbers an = new AddNumbers();

            an.Run();

            Console.ReadKey();
        }
    }
}
