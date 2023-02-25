using Examples.BasicCode;
using FluentAssertions;
using NUnit.Framework;

namespace ExamplesUnitTests.BasicCode
{
    public class CachedBoolTests
    {
        [Test]
        public void ShouldCachedBool_BeBull()
        {
            CachedBool cb = new CachedBool();
            cb.CachedValue.Should().BeNull();
        }

        [Test]
        public void ShouldCachedBool_BeTrue()
        {
            CachedBool cb = new CachedBool();
            cb.SetCache(true);
            cb.CachedValue.Should().BeTrue();
        }

        [Test]
        public void ShouldCachedBool_BeFalse()
        {
            CachedBool cb = new CachedBool();
            cb.SetCache(false);
            cb.CachedValue.Should().BeFalse();
        }
    }
}