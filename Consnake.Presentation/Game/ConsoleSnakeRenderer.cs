using Consnake.Core.Interfaces.Game;
using Consnake.Core.Models;

namespace SnakeAttemt.Presentation.Game
{
    public class ConsoleSnakeRenderer : IRenderer<Snake>
    {
        public void Render(Snake snake)
        {
            foreach (var segment in snake.Body)
            {
                Console.SetCursorPosition(segment.X, segment.Y);
                if (segment == snake.Head)
                {
                    Console.Write("O");
                }
                else
                {
                    Console.Write("o");
                }
                Console.SetCursorPosition(snake.LastTail.X, snake.LastTail.Y);
                Console.Write(' ');
            }
        }
    }
}
