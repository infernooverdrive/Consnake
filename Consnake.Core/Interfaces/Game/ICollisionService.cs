using Consnake.Core.Models;

namespace Consnake.Core.Interfaces.Game
{
    public interface ICollisionService
    {
        event Action SnakeCollided;
        event Action FoodEaten;

        void CheckCollisions(Snake snake, Arena arena, Food food);
    }
}
