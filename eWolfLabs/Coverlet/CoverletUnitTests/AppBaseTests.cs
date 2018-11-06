using Coverlet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoverletUnitTests
{
    [TestClass]
    public class AppBaseTests
    {
        [TestMethod]
        public void ShouldGetStringReturnEmpty()
        {
            AppBase pb = new AppBase();
            string str = pb.GetString(0);

            Assert.AreEqual(string.Empty, str);
        }
    }
}
