﻿using System;

namespace TennisTest
{
    public class Tennis
    {
        public int _firstPlayerScore { get; set; }
        public int _secondPlayerScore { get; set; }

        public string Score()
        {
            if (_firstPlayerScore == 1 && _secondPlayerScore == 0)
            {
                return "Fifteen Love";
            }

            return "Love All";
        }
    }
}