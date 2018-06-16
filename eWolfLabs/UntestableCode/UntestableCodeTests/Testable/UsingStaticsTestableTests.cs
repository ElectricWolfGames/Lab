using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using UntestableCode.Testable;

namespace UntestableCodeTests.Testable
{
    public class UsingStaticsTestableTests
    {
        private List<string> _outputs;

        [SetUp]
        public void SetUp()
        {
            _outputs = new List<string>();
        }

        [Test]
        public void ShouldLogOutInput()
        {
            UsingStaticsTestable ust = new UsingStaticsTestable(FakeUserInputGetInput, FakeLogger);
            ust.Run();

            _outputs.Should().HaveCount(2);
            _outputs[1].Should().Contain("MyInput");
        }

        private static void FakeUserInputGetInput(out string inputText)
        {
            inputText = "MyInput";
        }

        private void FakeLogger(string textToDisplay)
        {
            _outputs.Add(textToDisplay);
        }
    }
}
