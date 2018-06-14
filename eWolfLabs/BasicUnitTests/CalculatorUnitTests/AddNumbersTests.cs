using Calculator;
using FluentAssertions;
using NUnit.Framework;

namespace CalculatorUnitTests
{
    public class AddNumbersTest
    {
        [Test]
        public void ShouldParseText()
        {
            AddNumbers an = new AddNumbers();

            int value = an.ParseText("5");
            value.Should().Be(5);
        }
    }
}
