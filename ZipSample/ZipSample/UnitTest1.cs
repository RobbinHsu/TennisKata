using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ZipSample
{
    [TestClass]
    public class TennisTests
    {
        private Tennis _tennis = new Tennis();

        [TestMethod]
        public void Love_All() 
        {            
            ScoreShouldeBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennis.FirstPlayerScore();
            ScoreShouldeBe("Fifteen All");
        }
        private void ScoreShouldeBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Socre());
        }
    }
}
