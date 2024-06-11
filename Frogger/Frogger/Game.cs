using System;
using System.Threading;
using System.Threading.Tasks;

namespace Frogger
{
    internal class Game
    {
        public void Run()
        {
            Frog frog = new Frog();
            Car car1 = new Car(1);
            Car car2 = new Car(2);
            Car car3 = new Car(3);
            Car car4 = new Car(4);
            Car car5 = new Car(5);

            // Start the user input handling task
            Task.Run(() => HandleUserInput(frog));

            while (frog.Lives > 0)
            {
                ConsoleLines.PrintMap(frog, car1, car2, car3, car4, car5);
                MoveCars(car1, car2, car3, car4, car5);

                if (CheckForCollision(frog, car1, car2, car3, car4, car5))
                {
                    frog.SetPos(20, 6);
                }

                Thread.Sleep(100); // Adjust as needed to control the loop speed
            }

            ConsoleLines.GameOver();
        }

        private void MoveCars(params Car[] cars)
        {
            foreach (var car in cars)
            {
                car.Move(1);
            }
        }

        private bool CheckForCollision(Frog frog, params Car[] cars)
        {
            foreach (var car in cars)
            {
                if (frog.PosX == car.PosX && frog.PosY == car.PosY)
                {
                    frog.LoseALife();
                    return true;
                }
            }
            return false;
        }

        private async Task HandleUserInput(Frog frog)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var userKeyPress = Console.ReadKey(true);
                    switch (userKeyPress.Key)
                    {
                        case ConsoleKey.UpArrow:
                            frog.Move(0, -1);
                            break;
                        case ConsoleKey.DownArrow:
                            frog.Move(0, 1);
                            break;
                        case ConsoleKey.LeftArrow:
                            frog.Move(-1, 0);
                            break;
                        case ConsoleKey.RightArrow:
                            frog.Move(1, 0);
                            break;
                    }
                }
                await Task.Delay(10); // Small delay to prevent high CPU usage
            }
        }
    }
}
