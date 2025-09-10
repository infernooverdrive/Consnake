using Consnake.Game.Game;

namespace Consnake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = GameBuilder.CreateGame();
            game.Start();
        }
    }
}
