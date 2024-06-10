using static System.Net.Mime.MediaTypeNames;

namespace Frogger
{
    internal class ConsoleLines
    {
        public static void PrintMap(Frog frog, Car car1, Car car2, Car car3, Car car4, Car car5)
        {
            Console.Clear();
            WriteFrog(frog);
            WriteCar(car1);
            WriteCar(car2);
            WriteCar(car3);
            WriteCar(car4);
            WriteCar(car5);
            Console.SetCursorPosition(0, 8);
            Console.WriteLine($"You have {frog.Lives} lives left");
        }

        private static void WriteFrog(Frog frog)
        {
            Console.SetCursorPosition(frog.PosX, frog.PosY);
            string frogEmoji = "\U0001F438";
            Console.Write(frogEmoji);
        }
        private static void WriteCar(Car car)
        {
            Console.SetCursorPosition(car.PosX, car.PosY);
            string automobile = "\U0001F697";
            Console.Write(automobile);
        }


        public static void GameOver()
        {
            Console.Clear();
            Console.Write(" $$$$$$\\   $$$$$$\\  $$\\      $$\\ $$$$$$$$\\        $$$$$$\\  $$\\    $$\\ $$$$$$$$\\ $$$$$$$\\  \r\n$$  __$$\\ $$  __$$\\ $$$\\    $$$ |$$  _____|      $$  __$$\\ $$ |   $$ |$$  _____|$$  __$$\\ \r\n$$ /  \\__|$$ /  $$ |$$$$\\  $$$$ |$$ |            $$ /  $$ |$$ |   $$ |$$ |      $$ |  $$ |\r\n$$ |$$$$\\ $$$$$$$$ |$$\\$$\\$$ $$ |$$$$$\\          $$ |  $$ |\\$$\\  $$  |$$$$$\\    $$$$$$$  |\r\n$$ |\\_$$ |$$  __$$ |$$ \\$$$  $$ |$$  __|         $$ |  $$ | \\$$\\$$  / $$  __|   $$  __$$< \r\n$$ |  $$ |$$ |  $$ |$$ |\\$  /$$ |$$ |            $$ |  $$ |  \\$$$  /  $$ |      $$ |  $$ |\r\n\\$$$$$$  |$$ |  $$ |$$ | \\_/ $$ |$$$$$$$$\\        $$$$$$  |   \\$  /   $$$$$$$$\\ $$ |  $$ |\r\n \\______/ \\__|  \\__|\\__|     \\__|\\________|       \\______/     \\_/    \\________|\\__|  \\__|");
        }
    }
}
