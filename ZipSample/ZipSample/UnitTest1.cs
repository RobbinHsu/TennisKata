using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ZipSample
{
    [TestClass]
    public class TennisTests
    {
        private Tennis _tennis = new Tennis("Joey");

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
            GivenSecondPlayerScoreTimes(1);
            ScoreShouldeBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            GivenSecondPlayerScoreTimes(2);
            ScoreShouldeBe("Love Thirty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            GivenFirstPlayerScoreTimes(1);
            GivenSecondPlayerScoreTimes(1);
            ScoreShouldeBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            GivenFirstPlayerScoreTimes(2);
            GivenSecondPlayerScoreTimes(2);
            ScoreShouldeBe("Thirty All");
        }

        [TestMethod]
        public void Deuce()
        {
            GivenDeuce();
            ScoreShouldeBe("Deuce");
        }

        [TestMethod]
        public void FirstPlayer_Adv()
        {
            GivenDeuce();
            GivenFirstPlayerScoreTimes(1);
            ScoreShouldeBe("Joey Adv");
        }

        private void GivenDeuce()
        {
            GivenFirstPlayerScoreTimes(3);
            GivenSecondPlayerScoreTimes(3);
        }
        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScore();
            }
        }

        private void GivenSecondPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.SecondPlayerScore();
            }
        }

        private void ScoreShouldeBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Socre());
        }
    }
}
