using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardRock
{
    public class Gestures
    {
        public string name;
        public List<string> win;
        public List<string> lose; 

        public Gestures(string name, List<string> win, List<string> lose)
        {
            this.name = name;
            this.win = win;
            this.lose = lose;   
        }
    }
}
