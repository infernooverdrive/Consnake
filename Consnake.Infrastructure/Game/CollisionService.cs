using Consnake.Core.Interfaces.Game;
using Consnake.Core.Models;

namespace Consnake.Infrastructure.Game
{
    public class CollisionService : ICollisionService
    {
        public event Action SnakeCollided = delegate { };
        public event Action FoodEaten = delegate { };

        public void CheckCollisions(Snake snake, Arena arena, Food food)
        {
            if (CheckBorderCollisions(snake, arena) || CheckSelfCollisions(snake, arena))
                SnakeCollided?.Invoke();
            if (CheckFoodCollision(snake, food))
                FoodEaten?.Invoke();
        }

        private bool CheckBorderCollisions(Snake snake, Arena arena)
        {
            if (snake.Head.X <= 0 || snake.Head.X >= arena.Width - 1 || snake.Head.Y <= 0 || snake.Head.Y >= arena.Height - 1)
            {
                return true;
            }
            return false;
        }

        private bool CheckSelfCollisions(Snake snake, Arena arena)
        {
            if (snake.Body.Count > 1)
            {
                for (int i = 2; i < snake.Body.Count; i++)
                {
                    if (snake.Head.X == snake.Body[i].X && snake.Head.Y == snake.Body[i].Y)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool CheckFoodCollision(Snake snake, Food food)
        {
            if (snake.Head.X == food.X && snake.Head.Y == food.Y)
            {
                return true;
            }
            return false;
        }
    }
}
