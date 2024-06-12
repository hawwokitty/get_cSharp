using System.Xml.Linq;

namespace Snake
{
    internal static class ConsoleLines
    {
        private static string _greenSquareEmoji = "\U0001F7E9"; // Green Square 🟩
        public static void PrintMapAndSnake(Snake snake)
        {
            Console.Clear();
            DrawBorder();
            //PrintSnakeHead(snake);
            PrintSnakeBody(snake);

        }

        private static void PrintSnakeBody(Snake snake)
        {
            foreach (var bodyPart in snake.SnakeBody)
            {
                Console.SetCursorPosition(bodyPart.BodyPosX, bodyPart.BodyPosY);
                Console.Write("X");
            }
        }

        public static void PrintFood(int posX, int posY, Food food)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(food.GetFoodIcon());
        }

        //public static void PrintSnakeHead(Snake snake)
        //{
        //    Console.SetCursorPosition(snake.HeadPosX, snake.HeadPosY);
        //    Console.Write(_greenSquareEmoji);
        //}

        public static void DrawBorder()
        {
            // Get the width and height of the console window
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            // Draw the top border
            Console.SetCursorPosition(0, 0);
            Console.Write('┌');
            for (int i = 1; i < width - 1; i++)
            {
                Console.Write('─');
            }
            Console.Write('┐');

            // Draw the side borders
            for (int i = 1; i < height - 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('│');
                Console.SetCursorPosition(width - 1, i);
                Console.Write('│');
            }

            // Draw the bottom border
            Console.SetCursorPosition(0, height - 1);
            Console.Write('└');
            for (int i = 1; i < width - 1; i++)
            {
                Console.Write('─');
            }
            Console.Write('┘');
        }

        public static void GameOver()
        {
            Console.Clear();
            Console.Write(" $$$$$$\\   $$$$$$\\  $$\\      $$\\ $$$$$$$$\\        $$$$$$\\  $$\\    $$\\ $$$$$$$$\\ $$$$$$$\\  \r\n$$  __$$\\ $$  __$$\\ $$$\\    $$$ |$$  _____|      $$  __$$\\ $$ |   $$ |$$  _____|$$  __$$\\ \r\n$$ /  \\__|$$ /  $$ |$$$$\\  $$$$ |$$ |            $$ /  $$ |$$ |   $$ |$$ |      $$ |  $$ |\r\n$$ |$$$$\\ $$$$$$$$ |$$\\$$\\$$ $$ |$$$$$\\          $$ |  $$ |\\$$\\  $$  |$$$$$\\    $$$$$$$  |\r\n$$ |\\_$$ |$$  __$$ |$$ \\$$$  $$ |$$  __|         $$ |  $$ | \\$$\\$$  / $$  __|   $$  __$$< \r\n$$ |  $$ |$$ |  $$ |$$ |\\$  /$$ |$$ |            $$ |  $$ |  \\$$$  /  $$ |      $$ |  $$ |\r\n\\$$$$$$  |$$ |  $$ |$$ | \\_/ $$ |$$$$$$$$\\        $$$$$$  |   \\$  /   $$$$$$$$\\ $$ |  $$ |\r\n \\______/ \\__|  \\__|\\__|     \\__|\\________|       \\______/     \\_/    \\________|\\__|  \\__|");
        }
    }
}
