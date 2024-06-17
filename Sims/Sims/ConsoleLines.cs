namespace Sims
{
    internal static class ConsoleLines
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static string RequestString(this string message)
        {
            var output = "";
            while (string.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine(message);
                output = Console.ReadLine();
            }

            return output;
        }

        public static int RequestInt(this string message, int maxInt)
        {
            string input;
            int output = 0;
            bool isValidNum = false;

            while (!isValidNum)
            {
                Console.WriteLine(message);
                input = Console.ReadLine();

                isValidNum = int.TryParse(input, out output) && output > 0 && output < maxInt;
            }

            return output;
        }
    }
}
