using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisTest
{
    [TestClass]
    public class TennisTest
    {
        private Tennis tennis = new Tennis();

        [TestMethod]
        public void LoveAllTest()
        {
            FirstPlayerGetScore(0);
            ShouleBeEqual("Love All", tennis);
        }

        [TestMethod]
        public void FifteenLoveTest()
        {
            FirstPlayerGetScore(1);
            ShouleBeEqual("Fifteen Love", tennis);
        }

        [TestMethod]
        public void ThirtyLoveTest()
        {
            FirstPlayerGetScore(2);
            ShouleBeEqual("Thirty Love", tennis);
        }

        [TestMethod]
        public void FortyLoveTest()
        {
            FirstPlayerGetScore(3);
            ShouleBeEqual("Forty Love", tennis);
        }

        private void FirstPlayerGetScore(int scores)
        {
            for (int i = 0; i < scores; i++)
            {
                tennis._firstPlayerScore++;
            }
        }

        private void ShouleBeEqual(string expected, Tennis tennis)
        {
            Assert.AreEqual(expected, tennis.Score());
        }
    }
}
