using System.Collections.Generic;

namespace TennisKata
{
    public class Tennis
    {
        private int _firstPlayerScore;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" },
        };

        private int _secondPlayerScore;

        public string Score()
        {
            if (_firstPlayerScore > 0)
            {
                return $"{_scoreLookup[_firstPlayerScore]} Love";
            }

            if (_secondPlayerScore > 0)
            {
                return $"Love {_scoreLookup[_secondPlayerScore]}";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}