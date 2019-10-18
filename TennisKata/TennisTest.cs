using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata
{
    [TestClass]
    public class TennisTest
    {
        [TestMethod]
        public void Love_All()
        {
            var tennis = new Tennis();
            Assert.AreEqual("Love All", tennis.Score());
        }
    }
}