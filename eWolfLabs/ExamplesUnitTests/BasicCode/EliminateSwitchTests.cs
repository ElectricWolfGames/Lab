using Examples.BasicCode;
using FluentAssertions;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace ExamplesUnitTests.BasicCode
{
    [ExcludeFromCodeCoverage]
    public class EliminateSwitchTests
    {
        [TestCase(EliminateSwitch.SwitchableEnum.None, "My None")]
        [TestCase(EliminateSwitch.SwitchableEnum.First, "My First")]
        [TestCase(EliminateSwitch.SwitchableEnum.Second, "My Second")]
        [TestCase((EliminateSwitch.SwitchableEnum)12, "My Unknown")]
        public void ShouldReturnCorrectString(EliminateSwitch.SwitchableEnum myEnum, string expected)
        {
            EliminateSwitch sw = new EliminateSwitch();

            string result = sw.GetStringFromSwitch(myEnum);
            result.Should().Be(expected);
        }
    }
}
