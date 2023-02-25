using UntestableCode.Testable.Interface;

namespace UntestableCode.Testable
{
    public class LiveStaticHolder : IStaticHolder
    {
        public void GetUserInput(out string inputValue)
        {
            UserInput.GetUserInput(out inputValue);
        }

        public void GetUserKey(out char inputChar)
        {
            UserInput.GetUserKey(out inputChar);
        }
    }
}