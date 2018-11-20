﻿using System;
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
            GivenFirstPlayerScoreTimes(1);
            ScoreShouldeBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScoreTimes(2);
            ScoreShouldeBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            GivenFirstPlayerScoreTimes(3);
            ScoreShouldeBe("Forty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _tennis.SecondPlayerScore();
            ScoreShouldeBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            _tennis.SecondPlayerScore();
            _tennis.SecondPlayerScore();
            ScoreShouldeBe("Love Thirty");
        }

        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScore();
            }
        }

        private void ScoreShouldeBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Socre());
        }
    }
}
