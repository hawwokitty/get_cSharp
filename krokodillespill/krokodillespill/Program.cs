namespace krokodillespill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunCrocGame();
        }

        public static void RunCrocGame()
        {
            int points = 0;
            bool keepGoing = true;
            while (keepGoing)
            {
            Random rand = new Random();
            int randNum1 = rand.Next(1, 11);
            int randNum2 = rand.Next(1, 11);
            Console.WriteLine($"{randNum1} _ {randNum2} (type stop to quit)");
            var input = Console.ReadLine();
            if (randNum1 > randNum2 && input == ">")
            {
                points++;
                Console.WriteLine("Correct! " + $"You have {points} points");
            } else if (randNum1 < randNum2 && input == "<")
            {
                points++;
                Console.WriteLine("Correct! " + $"You have {points} points");
            }
            else if (randNum1 == randNum2 && input == "=")
            {
                points++;
                Console.WriteLine("Correct! " + $"You have {points} points");
            } else if (input == "stop")
            {
                keepGoing = false;
            }
            else
            {
                points--;
                Console.WriteLine("Wrong! " + $"You have {points} points");
            }
            }
            
        }
    }
}
