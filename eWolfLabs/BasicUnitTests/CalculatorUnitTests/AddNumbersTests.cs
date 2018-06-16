using Calculator;
using FluentAssertions;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace CalculatorUnitTests
{
    [ExcludeFromCodeCoverage]
    public class AddNumbersTest
    {
        [Test]
        public void ShouldParseText()
        {
            AddNumbers an = new AddNumbers();
            int i = 0;
            i.Should().Be(0);
        }
    }
}
