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
            while (frog.Lives > 0)
            {
                ConsoleLines.PrintMap(frog, car1, car2, car3, car4, car5);
                MoveCars(car1, car2, car3, car4, car5);
                UserKeyPress(frog);
                if (CheckForCollision(frog, car1, car2, car3, car4, car5))
                {
                    frog.SetPos(20, 6);
                }
            }

            ConsoleLines.GameOver();
        }

        private void MoveCars(Car car1, Car car2, Car car3, Car car4, Car car5)
        {
            car1.Move(1);
            car2.Move(1);
            car3.Move(1);
            car4.Move(1);
            car5.Move(1);
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


        private void UserKeyPress(Frog frog)
        {
            var userKeyPress = Console.ReadKey(intercept: true);
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
                default:
                    
                    break;
            }
        }
    }
}
