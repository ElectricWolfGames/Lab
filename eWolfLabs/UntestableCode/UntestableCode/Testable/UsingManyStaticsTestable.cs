using System;

namespace UntestableCode.Testable
{
    public class UsingManyStaticsTestable
    {
        private IStaticHolder _staticHolder;

        public UsingManyStaticsTestable()
        {
            _staticHolder = new LiveStaticHolder();
        }

        public UsingManyStaticsTestable(IStaticHolder staticHolder) : base()
        {
            _staticHolder = staticHolder;
        }

        public void Run()
        {
            Console.WriteLine("Input your value:");

            string inputValue;
            _staticHolder.GetUserInput(out inputValue);

            Console.WriteLine($"Here is your text = {inputValue}");

            Console.WriteLine("Input your value:");

            char inputChar;
            _staticHolder.GetUserKey(out inputChar);
            Console.WriteLine();

            Console.WriteLine($"Here is your key value = {inputChar}");
        }
    }
}
