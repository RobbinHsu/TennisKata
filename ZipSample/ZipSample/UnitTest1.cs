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
            ScoreShouldeBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            _tennis.FirstPlayerScore();
            _tennis.FirstPlayerScore();
            ScoreShouldeBe("Thirty Love");
        }

        private void ScoreShouldeBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Socre());
        }
    }
}
