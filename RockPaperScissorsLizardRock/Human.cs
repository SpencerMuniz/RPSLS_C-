using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardRock
{
    public class Human: Player
    {
        public Human(string name, int score)
        {
            this.name = name;
            this.score = score; 
        }
        public void ChooseGesture()
        {
            Console.WriteLine(this.name, "select gesture: ");
            Console.WriteLine("ROCK, PAPER, SCISSORS, LIZARD, SPOCK");
        }
    }
}
