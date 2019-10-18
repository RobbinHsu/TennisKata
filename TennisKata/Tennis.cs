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
        };

        public string Score()
        {
            if (_firstPlayerScore == 1 || _firstPlayerScore == 2)
            {
                return $"{_scoreLookup[_firstPlayerScore]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}