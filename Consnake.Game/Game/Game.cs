using Consnake.Core.Enums;
using Consnake.Core.Game;
using Consnake.Core.Interfaces.Controls;
using Consnake.Core.Interfaces.Game;
using Consnake.Core.Models;

namespace Consnake.Game.Game
{
    public class Game
    {
        private IPlayerInputHandler inputHandler;

        private IRenderer<Arena> arenaRenderer;
        private IRenderer<Snake> snakeRenderer;
        private IRenderer<Food> foodRenderer;

        private Snake snake;
        private ISnakeController snakeController;
        private ICollisionService collisionService;

        private Arena arena;

        private IFoodSpawner foodSpawner;
        private Food food;

        private GameState gameState = GameState.Running;

        public Game(IPlayerInputHandler inputHandler, ICollisionService collisionService, IRenderer<Arena> arenaRenderer, IRenderer<Snake> snakeRenderer, IRenderer<Food> foodRenderer, int width, int height)
        {
            this.inputHandler = inputHandler;

            this.arenaRenderer = arenaRenderer;
            this.snakeRenderer = snakeRenderer;
            this.foodRenderer = foodRenderer;

            this.collisionService = collisionService;

            snake = new Snake(width / 2, height / 2);
            snakeController = new SnakeController(snake);

            arena = new Arena(width, height);

            foodSpawner = new FoodSpawner(width, height);
            food = foodSpawner.SpawnFood();

            collisionService.FoodEaten += () => { snake.Grow(); food = foodSpawner.SpawnFood(); };
            collisionService.SnakeCollided += () => gameState = GameState.GameOver;
        }

        public void Start()
        {
            arenaRenderer.Render(arena);

            while (gameState != GameState.GameOver)
            {
                var inputDirection = inputHandler.GetDirection();

                snakeController.SetDirection(inputDirection);

                snakeController.Move();

                collisionService.CheckCollisions(snake, arena, food);

                foodRenderer.Render(food); snakeRenderer.Render(snake);

                Thread.Sleep(200);
            }
        }
    }
}
