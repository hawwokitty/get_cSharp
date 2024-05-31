namespace Klikkerspill
{
    internal class ClickerGame
    {
        public static int Points = 0;
        private static int _pointsPerClick = 1;
        private static int _pointsPerClickIncrease = 1;

        public void RunClickerGame()
        {
            Console.Clear();
            Console.WriteLine("Kommandoer:\r\n - SPACE = klikk(og få poeng)\r\n- K = kjøp oppgradering \r\nøker poeng per klikk koster 10 poeng\r\n- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n - X = avslutt applikasjonen");

            Console.WriteLine($"Du har {Points} poeng.");
            Console.WriteLine("Trykk tast for ønsket kommando.");
            CheckKeyPress();
        }
        private void CheckKeyPress()
        {
            char pressedKey = Console.ReadKey().KeyChar;
            CommandSet commandSet = new CommandSet();
            commandSet.RunCommand(pressedKey);
        }

        public static void IncreasePointsPerClick()
        {
            _pointsPerClickIncrease++;
        }

        public static void AddPointsPerClick()
        {
            _pointsPerClick += _pointsPerClickIncrease;
        }

        public static void Click()
        {
            Points += _pointsPerClick;
        }
    }
}
