using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using UntestableCode.Testable;

namespace UntestableCodeTests.Testable
{
    public class UsingManyStaticsTestableTests
    {
        private FakeStaticHolder _ksh;
        private List<string> _outputs;

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
    }
}