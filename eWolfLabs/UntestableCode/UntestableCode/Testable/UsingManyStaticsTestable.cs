using System;
using UntestableCode.Testable.Interface;

namespace UntestableCode.Testable
{
    public class UsingManyStaticsTestable
    {
        private readonly IStaticHolder _staticHolder;
        private readonly Action<string> _logger;

        public UsingManyStaticsTestable()
        {
            _staticHolder = new LiveStaticHolder();
        }

        public UsingManyStaticsTestable(IStaticHolder staticHolder, Action<string> logger) : base()
        {
            _staticHolder = staticHolder;
            _logger = logger;
        }

        public delegate void OutAction<T1>(out T1 inputData);

        public void Run()
        {
            _logger("Input your value:");

            string inputValue;
            _staticHolder.GetUserInput(out inputValue);

            _logger($"Here is your text = {inputValue}");

            _logger("Input your value:");

            char inputChar;
            _staticHolder.GetUserKey(out inputChar);
            _logger(string.Empty);

            _logger($"Here is your key value = {inputChar}");
        }
    }
}
