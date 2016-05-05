using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceRoller
{
    class Dice
    {
        Random r;
        public int roll;

        public int diceRoll()
        {
            r = new Random();
            roll = r.Next(1, 6) + r.Next(1,6); 
            return roll;
        }
    }
}
