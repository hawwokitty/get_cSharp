namespace FlappyBird
{
    internal class ConsoleLines
    {
        public static void PrintMapAndBird(Bird bird, List<Obstacle> obstacles)
        {
            Console.Clear();
            DrawBird(bird);
            foreach (Obstacle obstacle in obstacles)
            {
                DrawObstacles(obstacle);
            }
        }

        private static void DrawObstacles(Obstacle obstacle)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(obstacle.PosX, obstacle.PosY1);
            Console.WriteLine("X");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(obstacle.PosX, obstacle.PosY2);
            Console.WriteLine("X");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(obstacle.PosX, obstacle.PosY3);
            Console.WriteLine("X");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(obstacle.PosX, obstacle.PosY4);
            Console.WriteLine("X");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(obstacle.PosX, obstacle.PosY5);
            Console.WriteLine("X");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void DrawBird(Bird bird)
        {
            string butterflyEmoji = "\U0001F98B";
            Console.SetCursorPosition(bird.PosX, bird.PosY); 
            Console.WriteLine(butterflyEmoji);
        }

        public static void GameOver(int highscore)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" $$$$$$\\   $$$$$$\\  $$\\      $$\\ $$$$$$$$\\        $$$$$$\\  $$\\    $$\\ $$$$$$$$\\ $$$$$$$\\  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("$$  __$$\\ $$  __$$\\ $$$\\    $$$ |$$  _____|      $$  __$$\\ $$ |   $$ |$$  _____|$$  __$$\\ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$$ /  \\__|$$ /  $$ |$$$$\\  $$$$ |$$ |            $$ /  $$ |$$ |   $$ |$$ |      $$ |  $$ |");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("$$ |$$$$\\ $$$$$$$$ |$$\\$$\\$$ $$ |$$$$$\\          $$ |  $$ |\\$$\\  $$  |$$$$$\\    $$$$$$$  |");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("$$ |\\_$$ |$$  __$$ |$$ \\$$$  $$ |$$  __|         $$ |  $$ | \\$$\\$$  / $$  __|   $$  __$$< ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("$$ |  $$ |$$ |  $$ |$$ |\\$  /$$ |$$ |            $$ |  $$ |  \\$$$  /  $$ |      $$ |  $$ |");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\\$$$$$$  |$$ |  $$ |$$ | \\_/ $$ |$$$$$$$$\\        $$$$$$  |   \\$  /   $$$$$$$$\\ $$ |  $$ |");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" \\______/ \\__|  \\__|\\__|     \\__|\\________|       \\______/     \\_/    \\________|\\__|  \\__|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nYou passed {highscore} walls!");
        }

  
    }
}
