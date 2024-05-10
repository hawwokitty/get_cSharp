namespace switchOppgave;

internal class Program
{
    static void Run()
    {
        Console.WriteLine("Please type a number between 1 and 7:");
        int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

        string dayInWords;
        switch (dayOfTheWeek)
        {
            default: dayInWords = Run(); break;
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
