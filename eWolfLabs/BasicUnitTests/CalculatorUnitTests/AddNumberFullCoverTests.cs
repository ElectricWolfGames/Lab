using Calculator;
using FluentAssertions;
using NUnit.Framework;
using System.Collections;

namespace CalculatorUnitTests
{
    public class AddNumberFullCoverTests
    {
        private readonly Queue _myInputs = new Queue();

        [TestCase("5", 5)]
        [TestCase("15", 15)]
        [TestCase("-15", -15)]
        [TestCase("1,200", 1200)]
        public void ShouldParseText(string text, int expected)
        {
            AddNumberFullCover an = new AddNumberFullCover(null);

            int value = an.ParseText(text);
            value.Should().Be(expected);
        }

        [TestCase("a")]
        [TestCase("I love cats")]
        public void ShouldNotParseText(string text)
        {
            AddNumberFullCover an = new AddNumberFullCover(null);

            int value = an.ParseText(text);
            value.Should().Be(0);
        }

        [TestCase("20", "20", 40)]
        [TestCase("220", "0", 220)]
        [TestCase("words", "words", 0)]
        public void ShouldAddNumbers(string firstNumber, string secondNumber, int expected)
        {
            _myInputs.Clear();
            _myInputs.Enqueue(firstNumber);
            _myInputs.Enqueue(secondNumber);

            AddNumberFullCover an = new AddNumberFullCover(() => GetInput());
            int result = an.Run();
            result.Should().Be(expected);
        }

        public string GetInput()
        {
            return (string)_myInputs.Dequeue();
        }
    }
}