using System;

namespace UntestableCode.Testable
{
    public static class UserInput
    {
        public static void GetUserInput(out string text)
        {
            text = Console.ReadLine();
        }

        public static void GetUserKey(out char key)
        {
            key = Console.ReadKey().KeyChar;
        }
    }
}
