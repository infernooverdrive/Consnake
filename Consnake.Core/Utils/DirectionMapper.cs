using Consnake.Core.Enums;

namespace Consnake.Core.Utils
{
    public static class DirectionMapper
    {
        public static (int x, int y) MapDirectionToDelta(Direction direction)
        {
            return direction switch
            {
                Direction.Up => (0, -1),
                Direction.Down => (0, 1),
                Direction.Left => (-1, 0),
                Direction.Right => (1, 0),
                _ => throw new InvalidOperationException("Invalid direction")
            };
        }
    }
}
