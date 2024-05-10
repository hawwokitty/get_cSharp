namespace switchCases
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please type a number between 1 and 7:");
            int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

            string dayInWords = "That's not a weekday";
            switch (dayOfTheWeek)
            {
                default: Main(); break;
                case 1:
                    dayInWords = "Monday";
                    break;
                case 2:
                    dayInWords = "Tuesday";
                    break;
                case 3:
                    dayInWords = "Wednesday";
                    break;
                case 4:
                    dayInWords = "Thursday";
                    break;
                case 5:
                    dayInWords = "Friday";
                    break;
                case 6:
                    dayInWords = "Saturday";
                    break;
                case 7:
                    dayInWords = "Sunday";
                    break;
            };
            Console.WriteLine(dayInWords);
        
    }
    }
}
