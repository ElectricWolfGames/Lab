using System;

namespace UntestableCode.Testable
{
    public class UsingStaticsTestable
    {
        private readonly OutAction<string> _getInput;
        private readonly Action<string> _logger;

        public UsingStaticsTestable()
        {
            _getInput = UserInputGetInput;
            _logger = LogToScreen;
        }

        public UsingStaticsTestable(OutAction<string> getInput, Action<string> logger)
        {
            _getInput = getInput;
            _logger = logger;
        }

        public delegate void OutAction<T1>(out T1 inputData);

        public void Run()
        {
            _logger("Input your value:");

            string inputValue;
            _getInput.Invoke(out inputValue);
            _logger($"Here is your text = {inputValue}");
        }

        private void LogToScreen(string textToDisplay)
        {
            Console.WriteLine(textToDisplay);
        }

        private static void UserInputGetInput(out string inputText)
        {
            UserInput.GetUserInput(out inputText);
        }
    }
}
