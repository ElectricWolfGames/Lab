namespace Examples.BasicCode
{
    public class BasicSwitch
    {
        public enum SwitchableEnum
        {
            None,
            First,
            Second,
            Secondmore
        }

        public string GetStringFrom(SwitchableEnum value)
        {
            string retValue = "My Unknown";
            switch (value)
            {
                case SwitchableEnum.None:
                    retValue = "My None";
                    break;

                case SwitchableEnum.First:
                    retValue = "My First";
                    break;

                case SwitchableEnum.Second:
                    retValue = "My Second";
                    break;
            }
            return retValue;
        }
    }
}
