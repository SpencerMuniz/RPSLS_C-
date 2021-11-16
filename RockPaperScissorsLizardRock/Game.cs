using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardRock
{
    class Game
    {
        public bool UseRobot;
        public int rounds;
        Human Player1 = new Human("player1", 0);
        Human Player2 = new Human("player2", 0);
        Robot Alfred = new Robot("Robot", 0);
        public string Player1Gesture;
        public string Player2Gesture;
        public string RobotGesture;
        private readonly Random random = new Random();

        public Game(bool UseRobot, int rounds)
        {
            this.UseRobot = UseRobot;
            this.rounds = rounds;
        }
        public void RunGame()
        {
            DisplayWelcome();
            DisplayRules();
            SelectPlayers();
            ScoreCount();
            StartGame();
            DisplayWinner();
        }
        public int AIGesture(int min, int max)
        {
            return random.Next(min, max);
        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
        }
        public void DisplayRules()
        {
            Console.WriteLine("Rock beats Scissors and Lizard \nPaper beats Rock and Spock \nScissors beats Paper and Lizard \nLizard beats Paper and Spock \nSpock beats Rock and Scissors");
        }
        public void SelectPlayers()
        {
            Console.WriteLine("Please enter 1 for single player or 2 for multiplayer.");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                UseRobot = true;
            }
            else
            {
                UseRobot = false;
            }
        }
        public void ScoreCount()
        {
            Console.WriteLine("How many rounds would you like to play: ");
            rounds = int.Parse(Console.ReadLine());
        }
        public void StartGame()
        {
            Console.WriteLine("Player 1 enter your name: ");
            Player1.name = Console.ReadLine();
            if(UseRobot == false)
            {
                Console.WriteLine("Player 2 enter your name: ");
                Player2.name = Console.ReadLine();
            }
            else
            {

            }
            while (Player1.score / rounds <= .5 && Player2.score / rounds <= .5 && UseRobot == false)
            {
                Player1.ChooseGesture();
                Player1Gesture = Console.ReadLine();
                Player2.ChooseGesture();
                Player2Gesture = Console.ReadLine();
                Console.WriteLine(Player1.score);
                Console.WriteLine(Player2.score);
                
                    switch (Player1Gesture)
                    {
                        case "ROCK":
                            if(Player2Gesture == "SCISSORS" || Player2Gesture == "LIZARD")
                            {
                                Player1.ScoreCounter();
                                Console.WriteLine(Player1.name, "won this round!");
                            }
                            else if(Player2Gesture == "ROCK")
                            {
                                Console.WriteLine("Draw");
                            }
                            else
                            {
                                Player2.ScoreCounter();
                                Console.WriteLine(Player2.name, "won this round!");
                            }
                            break;
                        case "PAPER":
                            if (Player2Gesture == "ROCK" || Player2Gesture == "SPOCK")
                            {
                                Player1.ScoreCounter();
                                Console.WriteLine(Player1.name, "won this round!");
                            }
                            else if (Player2Gesture == "PAPER")
                            {
                                Console.WriteLine("Draw");
                            }
                            else
                            {
                                Player2.ScoreCounter();
                                Console.WriteLine(Player2.name, "won this round!");
                            }
                            break;
                        case "SCISSORS":
                            if (Player2Gesture == "PAPER" || Player2Gesture == "LIZARD")
                            {
                                Player1.ScoreCounter();
                                Console.WriteLine(Player1.name, "won this round!");
                            }
                            else if (Player2Gesture == "SCISSORS")
                            {
                                Console.WriteLine("Draw");
                            }
                            else
                            {
                                Player2.ScoreCounter();
                                Console.WriteLine(Player2.name, "won this round!");
                            }
                            break;
                        case "LIZARD":
                            if (Player2Gesture == "PAPER" || Player2Gesture == "SPOCK")
                            {
                                Player1.ScoreCounter();
                                Console.WriteLine(Player1.name, "won this round!");
                            }
                            else if (Player2Gesture == "LIZARD")
                            {
                                Console.WriteLine("Draw");
                            }
                            else
                            {
                                Player2.ScoreCounter();
                                Console.WriteLine(Player2.name, "won this round!");
                            }
                            break;
                        case "SPOCK":
                            if (Player2Gesture == "ROCK" || Player2Gesture == "SCISSORS")
                            {
                                Player1.ScoreCounter();
                                Console.WriteLine(Player1.name, "won this round!");
                            }
                            else if (Player2Gesture == "SPOCK")
                            {
                                Console.WriteLine("Draw");
                            }
                            else
                            {
                                Player2.ScoreCounter();
                                Console.WriteLine(Player2.name, "won this round!");
                            }
                            break;

                    }
                
            }
            while (Player1.score / rounds <= .5 && Alfred.score / rounds <= .5 && UseRobot == true);
            {
                Player1.ChooseGesture();
                Player1Gesture = Console.ReadLine();
                RobotGesture = AIGesture(1, 5);
                Console.WriteLine(Player1.score);
                Console.WriteLine(Alfred.score);
                switch (Player1Gesture)
                {
                    case "ROCK":
                        if (RobotGesture == 3 || RobotGesture == 4)
                        {
                            Player1.ScoreCounter();
                            Console.WriteLine(Player1.name, "won this round!");
                        }
                        else if (RobotGesture == 1)
                        {
                            Console.WriteLine("Draw");
                        }
                        else
                        {
                            Alfred.ScoreCounter();
                            Console.WriteLine(Alfred.name, "won this round!");
                        }
                        break;
                    case "PAPER":
                        if (RobotGesture == 1 || RobotGesture == 5)
                        {
                            Player1.ScoreCounter();
                            Console.WriteLine(Player1.name, "won this round!");
                        }
                        else if (RobotGesture == 2)
                        {
                            Console.WriteLine("Draw");
                        }
                        else
                        {
                            Alfred.ScoreCounter();
                            Console.WriteLine(Alfred.name, "won this round!");
                        }
                        break;
                    case "SCISSORS":
                        if (RobotGesture == 2 || RobotGesture == 4)
                        {
                            Player1.ScoreCounter();
                            Console.WriteLine(Player1.name, "won this round!");
                        }
                        else if (RobotGesture == 3)
                        {
                            Console.WriteLine("Draw");
                        }
                        else
                        {
                            Alfred.ScoreCounter();
                            Console.WriteLine(Alfred.name, "won this round!");
                        }
                        break;
                    case "LIZARD":
                        if (RobotGesture == 2 || RobotGesture == 5)
                        {
                            Player1.ScoreCounter();
                            Console.WriteLine(Player1.name, "won this round!");
                        }
                        else if (RobotGesture == 4)
                        {
                            Console.WriteLine("Draw");
                        }
                        else
                        {
                            Alfred.ScoreCounter();
                            Console.WriteLine(Alfred.name, "won this round!");
                        }
                        break;
                    case "SPOCK":
                        if (RobotGesture == 1 || RobotGesture == 3)
                        {
                            Player1.ScoreCounter();
                            Console.WriteLine(Player1.name, "won this round!");
                        }
                        else if (RobotGesture == 5)
                        {
                            Console.WriteLine("Draw");
                        }
                        else
                        {
                            Alfred.ScoreCounter();
                            Console.WriteLine(Alfred.name, "won this round!");
                        }
                        break;

                }

            }
        }
        public void DisplayWinner()
        {
            if(Player1.score / rounds > .5)
            {
                Console.WriteLine(Player1.name, " is the winner");
            }
            else if (Player2.score / rounds > .5)
            {
                Console.WriteLine(Player2.name, " is the winner");
            }
            else if (Alfred.score / rounds > .5)
            {
                Console.WriteLine(Alfred.name, " is the winner");
            }
        }
    }
}
