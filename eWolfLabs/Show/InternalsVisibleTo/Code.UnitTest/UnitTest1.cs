namespace Code.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldAddReturnAddedValues()
        {

            var code = new Class1();
            var result = code.Add(1, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void ShouldSubReturnSubValues()
        {

            var code = new Class1();
            var result = code.Sub(1, 1);

            Assert.That(result, Is.EqualTo(0));
        }
    }
}