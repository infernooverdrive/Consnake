using Consnake.Core.Interfaces.Game;
using Consnake.Core.Models;

namespace SnakeAttemt.Presentation.Game
{
    public class ConsoleArenaRenderer : IRenderer<Arena>
    {
        public void Render(Arena arena)
        {
            for (int i = 0; i < arena.Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("#");
                Console.SetCursorPosition(i, arena.Height - 1);
                Console.Write("#");
            }

            for (int i = 0; i < arena.Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("#");
                Console.SetCursorPosition(arena.Width - 1, i);
                Console.Write("#");
            }
        }
    }
}
