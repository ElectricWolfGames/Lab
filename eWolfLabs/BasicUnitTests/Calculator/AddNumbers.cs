using System;

namespace Calculator
{
    public class AddNumbers
    {
        private int _firstNumber;
        private int _secondNumber;

        internal int Run()
        {
            Console.WriteLine("Give me your first number");
            _firstNumber = GetInputNumber();

            Console.WriteLine("Give me your second number");
            _secondNumber = GetInputNumber();

            int added = _firstNumber + _secondNumber;
            Console.WriteLine($"Add them together and we get {added}");

            return added;
        }

        private int GetInputNumber()
        {
            string text = Console.ReadLine();
            return int.Parse(text);
        }
    }
}