using System;
using System.Collections.Generic;

namespace Examples.BasicCode
{
    public class EliminateSwitch
    {
        private readonly Dictionary<SwitchableEnum, Func<string>> _enumMap = new Dictionary<SwitchableEnum, Func<string>>()
        {
            { SwitchableEnum.None, SetMyNone },
            { SwitchableEnum.First, SetMyFirst },
            { SwitchableEnum.Second, SetMySecond }
        };

        public enum SwitchableEnum
        {
            None,
            First,
            Second
        }

        public string GetStringFrom(SwitchableEnum value)
        {
            string retValue = "My Unknown";

            Func<string> callable;
            if (_enumMap.TryGetValue(value, out callable))
            {
                retValue = callable.Invoke();
            }

            return retValue;
        }

        private static string SetMyFirst()
        {
            return "My First";
        }

        private static string SetMyNone()
        {
            return "My None";
        }

        private static string SetMySecond()
        {
            return "My Second";
        }
    }
}