using Consnake.Core.Enums;

namespace Consnake.Core.Interfaces.Game
{
    public interface ISnakeController
    {
        public void SetDirection(Direction newDirection);

        public void Move();

        public void Eat();
    }
}
