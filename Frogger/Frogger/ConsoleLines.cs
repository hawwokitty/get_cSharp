using static System.Net.Mime.MediaTypeNames;

namespace Frogger
{
    internal class ConsoleLines
    {
        public static void PrintMap(Frog frog, params Car[] cars)
        {
            Console.Clear();
            WriteFrog(frog);
            foreach (var car in cars)
            {
                WriteCar(car);
            }
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

        public static void Winner()
        {
            Console.Clear();
            Console.WriteLine("$$\\     $$\\  $$$$$$\\  $$\\   $$\\       $$\\      $$\\ $$$$$$\\ $$\\   $$\\ $$\\ \r\n\\$$\\   $$  |$$  __$$\\ $$ |  $$ |      $$ | $\\  $$ |\\_$$  _|$$$\\  $$ |$$ |\r\n \\$$\\ $$  / $$ /  $$ |$$ |  $$ |      $$ |$$$\\ $$ |  $$ |  $$$$\\ $$ |$$ |\r\n  \\$$$$  /  $$ |  $$ |$$ |  $$ |      $$ $$ $$\\$$ |  $$ |  $$ $$\\$$ |$$ |\r\n   \\$$  /   $$ |  $$ |$$ |  $$ |      $$$$  _$$$$ |  $$ |  $$ \\$$$$ |\\__|\r\n    $$ |    $$ |  $$ |$$ |  $$ |      $$$  / \\$$$ |  $$ |  $$ |\\$$$ |    \r\n    $$ |     $$$$$$  |\\$$$$$$  |      $$  /   \\$$ |$$$$$$\\ $$ | \\$$ |$$\\ \r\n    \\__|     \\______/  \\______/       \\__/     \\__|\\______|\\__|  \\__|\\__|");
        }
    }
}
