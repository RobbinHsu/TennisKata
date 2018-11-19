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

        private Dictionary<int, string> scoreLookup = new Dictionary<int, string>
        {
            { 1,"Fifteen" },
            { 2,"Thirty" },
        };

        public string Socre()
        {

            if(_firstPlayerScoreTimes==1 || _firstPlayerScoreTimes == 2)
            {
                return $"{scoreLookup[_firstPlayerScoreTimes]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}
