using Consnake.Core.Enums;

namespace Consnake.Core.Utils
{
    public static class DirectionHelper
    {
        public static bool IsOppositeDirection(Direction previous, Direction current)
        {
            return (previous == Direction.Up && current == Direction.Down) ||
                    (previous == Direction.Down && current == Direction.Up) ||
                    (previous == Direction.Left && current == Direction.Right) ||
                    (previous == Direction.Right && current == Direction.Left);
        }
    }
}
