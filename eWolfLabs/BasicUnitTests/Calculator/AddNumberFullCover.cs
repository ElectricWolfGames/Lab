using System;

namespace Calculator
{
    public class AddNumberFullCover
    {
        private int _firstNumber;
        private int _secondNumber;
        private readonly Func<string> _input;

        public AddNumberFullCover()
        {
            _input = GetInput;
        }

        public AddNumberFullCover(Func<string> input) : base()
        {
            _input = input;
        }

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

        public string GetInput()
        {
            return Console.ReadLine();
        }

        private int GetInputNumber()
        {
            string text = _input.Invoke();
            return ParseText(text);
        }

        internal int ParseText(string text)
        {
            int comma = text.IndexOf(",");
            if (comma > -1)
            {
                text = text.Remove(comma, 1);
            }

            int result;
            if (int.TryParse(text, out result))
            {
                return result;
            }
            return 0;
        }
    }
}
