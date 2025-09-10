using Consnake.Core.Enums;
using Consnake.Core.Interfaces.Game;
using Consnake.Core.Models;
using Consnake.Core.Utils;

namespace Consnake.Core.Game
{
    public class SnakeController : ISnakeController
    {
        private Snake snake;
        private Direction direction = Direction.Up;

        public SnakeController(Snake snake)
        {
            this.snake = snake;
        }

        public void SetDirection(Direction newDirection)
        {
            if (!DirectionHelper.IsOppositeDirection(direction, newDirection))
            {
                direction = newDirection;
            }
        }

        private (int deltaX, int deltaY) GetDelta()
        {
            return DirectionMapper.MapDirectionToDelta(direction);
        }

        public void Move()
        {
            var (deltaX, deltaY) = GetDelta();
            snake.Move(deltaX, deltaY);
        }

        public void Eat()
        {
            snake.Grow();
        }
    }
}
