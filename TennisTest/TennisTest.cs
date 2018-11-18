using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisTest
{
    [TestClass]
    public class TennisTest
    {
        [TestMethod]
        public void LoveAllTest()
        {
            var tennis = new Tennis();
            Assert.AreEqual("Love All", tennis.Score());
        }

        [TestMethod]
        public void FifteenLoveTest()
        {
            var tennis = new Tennis();
            tennis._firstPlayerScore++;
            Assert.AreEqual("Fifteen Love", tennis.Score());
        }

        [TestMethod]
        public void ThirtyLoveTest()
        {
            var tennis = new Tennis();
            tennis._firstPlayerScore++;
            tennis._firstPlayerScore++;
            Assert.AreEqual("Thirty Love", tennis.Score());
        }
    }
}
