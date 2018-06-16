using System;

namespace UntestableCode.Untestable
{
    public static class UserInput
    {
        public static void GetUserInput(out string text)
        {
            text = Console.ReadLine();
        }
    }
}
