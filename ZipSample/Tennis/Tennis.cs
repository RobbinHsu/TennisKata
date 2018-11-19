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

        public string Socre()
        {
            if(_firstPlayerScoreTimes==1)
            {
                return "Fifteen Love";
            } 

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}
