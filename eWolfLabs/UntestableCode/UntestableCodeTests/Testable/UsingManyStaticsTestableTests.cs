using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using UntestableCode.Testable;

namespace UntestableCodeTests.Testable
{
    public class UsingManyStaticsTestableTests
    {
        private List<string> _outputs;
        private FakeStaticHolder _ksh;

        [SetUp]
        public void SetUp()
        {
            _outputs = new List<string>();

            _ksh = new FakeStaticHolder();
            _ksh.OutputsStrings.Enqueue("My long text");
            _ksh.OutputsKeys.Enqueue('k');
        }

        [Test]
        public void ShouldOutputBothFields()
        {
            UsingManyStaticsTestable ust = new UsingManyStaticsTestable(_ksh, FakeLogger);
            ust.Run();

            _outputs.Should().HaveCount(5);
            _outputs[1].Should().Contain("My long text");
            _outputs[4].Should().Contain("k");
        }

        private void FakeLogger(string textToDisplay)
        {
            _outputs.Add(textToDisplay);
        }

        private class FakeStaticHolder : IStaticHolder
        {
            public readonly Queue<string> OutputsStrings = new Queue<string>();
            public readonly Queue<char> OutputsKeys = new Queue<char>();

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
}
