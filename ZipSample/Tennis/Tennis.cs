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
        private string _firstPlayerName;

        private Dictionary<int, string> scoreLookup = new Dictionary<int, string>
        {
            { 0,"Love" },
            { 1,"Fifteen" },
            { 2,"Thirty" },
            { 3,"Forty" },
        };
        

        public Tennis(string firstPlayerName)
        {
            _firstPlayerName = firstPlayerName;
        }

        public string Socre()
        {
            if (IsScoreDifferent())
            {
                if(_firstPlayerScoreTimes>3)
                {
                    if(_firstPlayerScoreTimes- _secondPlayerScoreTimes==1)
                    {
                        return "Joey Adv";
                    }
                }
                return LookupScore();
            }
            
            if(IsDuece())
            {
                return "Deuce";
            }
            return SameScore();
        }

        private bool IsDuece()
        {
            return _firstPlayerScoreTimes >= 3;
        }
        private bool IsScoreDifferent()
        {
            return _firstPlayerScoreTimes != _secondPlayerScoreTimes;
        }
        private string LookupScore()
        {
            return $"{scoreLookup[_firstPlayerScoreTimes]} {scoreLookup[_secondPlayerScoreTimes]}";
        }

        private string SameScore()
        {
            return $"{scoreLookup[_firstPlayerScoreTimes]} All";
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
