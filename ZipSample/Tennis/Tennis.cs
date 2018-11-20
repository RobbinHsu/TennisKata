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
            { 0,"Love" },
            { 1,"Fifteen" },
            { 2,"Thirty" },
            { 3,"Forty" },
        };
        

        public string Socre()
        {
            if(_firstPlayerScoreTimes > 0  || _secondPlayerScoreTimes > 0)
            {
                return $"{scoreLookup[_firstPlayerScoreTimes]} {scoreLookup[_secondPlayerScoreTimes]}";
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
