namespace TextAdventure
{
    internal class ConsoleLines
    {
        public void PrintLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}