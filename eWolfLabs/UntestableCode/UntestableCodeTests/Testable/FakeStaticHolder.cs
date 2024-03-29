﻿using System.Collections.Generic;
using UntestableCode.Testable.Interface;

namespace UntestableCodeTests.Testable
{
    public class FakeStaticHolder : IStaticHolder
    {
        public readonly Queue<char> OutputsKeys = new Queue<char>();
        public readonly Queue<string> OutputsStrings = new Queue<string>();

        public void GetUserInput(out string inputValue)
        {
            inputValue = OutputsStrings.Dequeue();
        }

        public void GetUserKey(out char inputChar)
        {
            inputChar = OutputsKeys.Dequeue();
        }
    }
}