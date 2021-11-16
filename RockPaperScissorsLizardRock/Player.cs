using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardRock
{
    public class Player
    {
        public string name;
        public int score;
        public Player()
        {

        }
        public void ScoreCounter()
        {
            score += 1;
        }
        
    }
}
