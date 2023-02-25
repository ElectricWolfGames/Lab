using System;

namespace UntestableCode.Untestable
{
    public class UsingManyStaticsUntestable
    {
        public UsingManyStaticsUntestable()
        {
        }

        public void Run()
        {
            Console.WriteLine("Input your value:");

            string inputValue;
            UserInput.GetUserInput(out inputValue);

            Console.WriteLine($"Here is your text = {inputValue}");

            Console.WriteLine("Input your value:");

            char inputChar;
            UserInput.GetUserKey(out inputChar);
            Console.WriteLine();

            Console.WriteLine($"Here is your key value = {inputChar}");
        }
    }
}