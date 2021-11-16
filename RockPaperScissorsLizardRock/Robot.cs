using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardRock
{
    class Robot
    {
        public string name;
        public int health;

        public Robot(string nameThatWasPassedIn, int health)
        {
            name = nameThatWasPassedIn;
            this.health = health;
        }
    }
}
