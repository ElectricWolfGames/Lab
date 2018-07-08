using BranchCoverExample;
using FluentAssertions;
using NUnit.Framework;

namespace BranchCoverExampleUnitTests
{
    public class LineCoveredTests
    {
        [Test]
        public void ShouldCoverAllLinesForTypeA()
        {
            LineCovered lv = new LineCovered();
            var dataObject = lv.DoStuff("a");
            dataObject.Value.Should().Be(10);
        }

        [Test]
        public void ShouldCoverAllLinesForTypeB()
        {
            LineCovered lv = new LineCovered();
            var dataObject = lv.DoStuff("b");
            dataObject.Value.Should().Be(20);
        }
    }
}
