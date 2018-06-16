using System;

namespace UntestableCode.Testable
{
    public static class UserInput
    {
        public static void GetUserInput(out string text)
        {
            text = Console.ReadLine();
        }
    }
}
