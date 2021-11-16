namespace RockPaperScissorsLizardRock
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while(playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                while (player != "Rock" && player != "Paper" && player != "Scissors" && player != "Lizard" && player != "Spock")
                {
                Console.Write("Enter Rock, Paper, Scissors, Lizard, or Spock: ");
                player = Console.ReadLine();
                }
                
                switch (random.Next(1, 5))
                   {
                    case 1:
                        computer = "Rock";
                        break;
                    case 2:
                        computer = "Paper";
                        break ;
                    case 3:
                        computer = "Scissors";
                        break;
                    case 4:
                        computer = "Lizard";
                        break;
                    case 5:
                        computer = "Spock";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "Rock":
                        if(computer == "Rock")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if(computer == "Paper")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "Scissors")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "Lizard")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "Spock")
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "Paper":
                        if (computer == "Rock")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "Paper")
                        {
                            Console.WriteLine("Draw!");
                        }
                        else if (computer == "Scissors")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "Lizard")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "Spock")
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "Scissors":
                        if (computer == "Rock")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "Paper")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "Scissors")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (computer == "Lizard")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "Spock")
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "Lizard":
                        if (computer == "Rock")
                        {
                            Console.WriteLine("You lose");
                        }
                        else if (computer == "Paper")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "Scissors")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "Lizard")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (computer == "Spock")
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "Spock":
                        if (computer == "Rock")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "Paper")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "Scissors")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "Lizard")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "Spock")
                        {
                            Console.WriteLine("Draw");
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again (Y/N)? ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }

            Game game = new Game();
            game.Run();
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }
}