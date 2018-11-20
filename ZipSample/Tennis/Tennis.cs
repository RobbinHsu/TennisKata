using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipSample
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private Dictionary<int, string> scoreLookup = new Dictionary<int, string>
        {
            { 1,"Fifteen" },
            { 2,"Thirty" },
            { 3,"Forty" },
        };
        

        public string Socre()
        {
            if(_secondPlayerScoreTimes==1 || _secondPlayerScoreTimes == 2)
            {
                return $"Love {scoreLookup[_secondPlayerScoreTimes]}";
            }
            if (_firstPlayerScoreTimes > 0)
            {
                return $"{scoreLookup[_firstPlayerScoreTimes]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}
