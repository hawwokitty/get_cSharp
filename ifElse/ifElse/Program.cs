namespace ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type an integer:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type another integer, it could be the same:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            bool answer = CalculateNumbers(number1, number2);
            Console.WriteLine($"if the nummbers add up to be 30, or either of the numbers are 30 you get truenm: {answer}");
        }

        public static bool CalculateNumbers(int number1, int number2)
        {
            bool answer;
            int number = number1 + number2;
            if (number == 30 || number1 == 30 || number2 == 30)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }
    }
}

 /* Oppgave 1
  static void Main(string[] args)
{
    Console.WriteLine("Please type an integer:");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please type the same integer again:");
    int number2 = Convert.ToInt32(Console.ReadLine());
    bool IsSame = AreTheseNumbersTheSameQuestion(number1, number2);
    Console.WriteLine($"Are the numbers the same? {IsSame}");
}

public static bool AreTheseNumbersTheSameQuestion(int number1, int number2)
{
    bool IsSame = false;
    if (number1 == number2)
    {
        IsSame = true;
    }
    else
    {
        IsSame = false;
    }

    return IsSame;
} 
 
oppgave 2
static void Main(string[] args)
    {
        Console.WriteLine("Please type an integer:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please type another integer, it could be the same:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int answer = CalculateNumbers(number1, number2);
        Console.WriteLine($"if the numbers are the same, they got multiplied, if they were different they got added together: {answer}");
    }
    
    public static int CalculateNumbers(int number1, int number2)
    {
        int answer;
        if (number1 == number2)
        {
            answer = number1*number2;
        }
        else
        {
            answer = number1+number2;
        }
    
        return answer;
    }
  
  */
 