using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardRock
{
    class Robot: Player
    {
       public Robot(string name, int score)
        {
            this.name = name;
            this.score = score;
           
        }
    }
}
