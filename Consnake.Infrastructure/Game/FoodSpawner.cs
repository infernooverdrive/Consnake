using Consnake.Core.Interfaces.Game;
using Consnake.Core.Models;

namespace Consnake.Core.Game
{
    public class FoodSpawner : IFoodSpawner
    {
        private Random random = new Random();
        private int arenaWidth;
        private int arenaHeight;

        public FoodSpawner(int arenaWidth, int arenaHeight)
        {
            this.arenaWidth = arenaWidth;
            this.arenaHeight = arenaHeight;
        }

        public Food SpawnFood()
        {
            int x = random.Next(1, arenaWidth - 1);
            int y = random.Next(1, arenaHeight - 1);
            return new Food(x, y);
        }
    }
}
