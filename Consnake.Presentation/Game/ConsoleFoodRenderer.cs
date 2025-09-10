using Consnake.Core.Interfaces.Game;
using Consnake.Core.Models;

namespace SnakeAttemt.Presentation.Game
{
    public class ConsoleFoodRenderer : IRenderer<Food>
    {
        public void Render(Food food)
        {
            Console.SetCursorPosition(food.X, food.Y);
            Console.Write("*");
        }
    }
}
