using Consnake.Infrastructure.Controls;
using Consnake.Infrastructure.Game;
using SnakeAttemt.Presentation.Game;

namespace Consnake.Game.Game
{
    public class GameBuilder
    {
        public static Game CreateGame()
        {
            var inputHandler = new ConsolePlayerInputHandler();

            var arenaRenderer = new ConsoleArenaRenderer();
            var snakeRenderer = new ConsoleSnakeRenderer();
            var foodRenderer = new ConsoleFoodRenderer();

            var collisionService = new CollisionService();

            int height = Console.WindowHeight;
            int width = Console.WindowWidth;

            return new Game(inputHandler, collisionService, arenaRenderer, snakeRenderer, foodRenderer, width, height);
        }
    }
}
