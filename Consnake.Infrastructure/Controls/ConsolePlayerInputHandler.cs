using Consnake.Core.Enums;
using Consnake.Core.Interfaces.Controls;

namespace Consnake.Infrastructure.Controls
{
    public class ConsolePlayerInputHandler : IPlayerInputHandler
    {
        private Direction lastDirection = Direction.Up;
        public Direction GetDirection()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                lastDirection = key switch
                {
                    ConsoleKey.UpArrow => Direction.Up,
                    ConsoleKey.DownArrow => Direction.Down,
                    ConsoleKey.LeftArrow => Direction.Left,
                    ConsoleKey.RightArrow => Direction.Right,
                    _ => lastDirection
                };
            }
            return lastDirection;
        }
    }
}