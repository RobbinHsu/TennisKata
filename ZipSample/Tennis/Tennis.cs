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
            var scoreLookup = new Dictionary<int, string>
            {
                {1,"Fifteen" },
                {2,"Thrity" },
            };
            if(_firstPlayerScoreTimes==1)
            {
                return $"{scoreLookup[_firstPlayerScoreTimes]} Love";
            }
            if (_firstPlayerScoreTimes == 2)
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
