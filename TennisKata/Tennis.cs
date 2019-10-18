using System.Collections.Generic;

namespace TennisKata
{
    public class Tennis
    {
        private readonly string _firstPlayerName;
        private int _firstPlayerScore;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" },
        };

        private int _secondPlayerScore;

        public Tennis(string firstPlayerName)
        {
            _firstPlayerName = firstPlayerName;
        }

        public string Score()
        {
            if (_firstPlayerScore != _secondPlayerScore)
            {
                if (_firstPlayerScore > 3)
                {
                    if (_firstPlayerScore - _secondPlayerScore == 1)
                    {
                        return $"{_firstPlayerName} Adv";
                    }
                }

                return $"{_scoreLookup[_firstPlayerScore]} {_scoreLookup[_secondPlayerScore]}";
            }

            if (_firstPlayerScore == 3)
            {
                return "Deuce";
            }
            return $"{_scoreLookup[_firstPlayerScore]} All";
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