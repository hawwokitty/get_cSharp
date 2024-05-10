using System.Reflection.Metadata.Ecma335;

namespace variabeltilordning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tall1 = 4; 
            int tall2 = 8;

            Console.WriteLine($"Summen av {tall1} og {tall2} er {SummerTall(tall1, tall2)}");
            IngenRetur();
            Console.ReadKey();
        }

        public static int SummerTall(int number1, int number2)
        {
            return number1 + number2;
        }

        public static void IngenRetur()
        {
            Console.WriteLine("Denne metoden returnerer ingenting");
        }


    }
}
