namespace RockPaperScissorsLizardRock
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(true, 5);
            game.RunGame();
        }
    }
}
