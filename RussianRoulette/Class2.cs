using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulette
{
    class ScoreBoard
    {
        int wins = 0;
        int losses = 0;

        public int updateLosses()
        {
            losses++;
            return losses;
        }
        public int updateWins()
        {
            wins++;
            return wins;
        }
    }

}
