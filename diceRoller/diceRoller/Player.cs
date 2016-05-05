using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceRoller
{
    class Player
    {
        public int CurrentWins { get; set; }
        public int CurrentLosses { get; set; }
        public int CurrentRoll { get; set; }

        public Player()
        {
            CurrentWins = 0;
            CurrentLosses = 0;
        }
    }
}
