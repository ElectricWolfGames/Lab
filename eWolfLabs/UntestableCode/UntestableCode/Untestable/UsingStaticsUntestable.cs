using System;

namespace UntestableCode.Untestable
{
    public class UsingStaticsUntestable
    {
        public UsingStaticsUntestable()
        {
        }

        public void Run()
        {
            Console.WriteLine("Input your value:");

            string inputValue;
            UserInput.GetUserInput(out inputValue);

            Console.WriteLine($"Here is your text = {inputValue}");
        }
    }
}