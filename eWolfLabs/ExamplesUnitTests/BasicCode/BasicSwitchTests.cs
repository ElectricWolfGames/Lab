using Examples.BasicCode;
using FluentAssertions;
using NUnit.Framework;

namespace ExamplesUnitTests.BasicCode
{
    public class BasicSwitchTests
    {
        [TestCase(BasicSwitch.SwitchableEnum.None, "My None")]
        [TestCase(BasicSwitch.SwitchableEnum.First, "My First")]
        [TestCase(BasicSwitch.SwitchableEnum.Second, "My Second")]
        [TestCase((BasicSwitch.SwitchableEnum)12, "My Unknown")]
        public void ShouldReturnCorrectString(BasicSwitch.SwitchableEnum myEnum, string expected)
        {
            BasicSwitch sw = new BasicSwitch();

            string result = sw.GetStringFrom(myEnum);
            result.Should().Be(expected);
        }
    }
}
