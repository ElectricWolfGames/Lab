using Coverlet;
using FluentAssertions;
using NUnit.Framework;

namespace CoverletUnitTests
{
    public class AppBaseTests
    {
        [Test]
        public void ShouldGetStringReturnEmpty()
        {
            AppBase pb = new AppBase();
            string str = pb.GetString(0);

            str.Should().Be(string.Empty);
        }
    }
}
