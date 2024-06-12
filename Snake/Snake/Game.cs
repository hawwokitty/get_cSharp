﻿using System.Xml.Linq;

namespace Snake
{
    internal class Game
    {
        private (int X, int Y) _previousMoveDone { get; set; }
        public void Run()
        {
            ConsoleLines.DrawBorder();
            Snake snake = new Snake();
            Task.Run(() => HandleUserInput(snake));
            Food food = new Food();
            _previousMoveDone = (-1, 0);
            while (snake.IsAlive)
            {
                ConsoleLines.PrintMapAndSnake(snake);
                ConsoleLines.PrintFood(food.FoodPosX, food.FoodPosY, food);
                snake.Move(_previousMoveDone.X, _previousMoveDone.Y);
                CheckForInteraction(snake, food);
                snake.MoveBody(_previousMoveDone.X, _previousMoveDone.Y);
                if (food.IsEaten)
                {
                    food = new Food();
                }
                Thread.Sleep(snake.Speed);
            }

            ConsoleLines.GameOver();
        }

        private void CheckForInteraction(Snake snake, Food food)
        {
            //foreach (var bodyPart in snake.SnakeBody)
            //{
            //    if (snake.HeadPosX == bodyPart.BodyPosX && snake.HeadPosY == bodyPart.BodyPosY)
            //    {
            //        snake.IsAlive = false;
            //    }
            //}
            if (snake.SnakeBody.Count >= 1)
            {
                for (int i = 1; i < snake.SnakeBody.Count; i++)
                {
                    if (snake.SnakeBody[0].BodyPosX == snake.SnakeBody[i].BodyPosX &&
                        snake.SnakeBody[0].BodyPosY == snake.SnakeBody[i].BodyPosY)
                    {
                        snake.IsAlive = false;
                    }
                    
                }

            }
            if (snake.SnakeBody[0].BodyPosX == food.FoodPosX && snake.SnakeBody[0].BodyPosY == food.FoodPosY)
            {
                snake.Grow(_previousMoveDone);
                food.GetsEaten();
            }
            else if (snake.SnakeBody[0].BodyPosX == Console.WindowWidth - 1 || snake.SnakeBody[0].BodyPosX == 1 ||
                     snake.SnakeBody[0].BodyPosY == Console.WindowHeight - 1 || snake.SnakeBody[0].BodyPosY == 1)
            {
                snake.IsAlive = false;
            }
            //if (snake.HeadPosX == food.FoodPosX && snake.HeadPosY == food.FoodPosY)
            //{
            //    snake.Grow(_previousMoveDone);
            //    food.GetsEaten();
            //} else if (snake.HeadPosX == Console.WindowWidth - 1 || snake.HeadPosX == 1 ||
            //           snake.HeadPosY == Console.WindowHeight - 1 || snake.HeadPosY == 1)
            //{
            //    snake.IsAlive = false;
            //} 
        }


        private async Task HandleUserInput(Snake snake)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var userKeyPress = Console.ReadKey(true);
                    switch (userKeyPress.Key)
                    {
                        case ConsoleKey.UpArrow:
                            snake.Move(0, -1);
                            _previousMoveDone = (0, -1);
                            break;
                        case ConsoleKey.DownArrow:
                            snake.Move(0, 1);
                            _previousMoveDone = (0, 1);
                            break;
                        case ConsoleKey.LeftArrow:
                            snake.Move(-1, 0);
                            _previousMoveDone = (-1, 0);
                            break;
                        case ConsoleKey.RightArrow:
                            snake.Move(1, 0);
                            _previousMoveDone = (1, 0);
                            break;
                    }
                }
                await Task.Delay(10);
            }
        }
    }
}
