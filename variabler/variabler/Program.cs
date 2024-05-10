namespace variabler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heltall = 19;
            long langtHeltall = 29480394823;

            float floatDecimal = 1.32F; // nøyaktig (opptil 7 tALL ETTER DECIMAL?
            decimal decimalDecimal = 444.3444M; // veldig nøyaktig
            double doubleDecimal = 4.18; // mest brukt?

            char bokstav = 'a';
            string tekst = "Lenger tekst";

            bool santUsant = false; // eller true
            Oppgave2();

        }

        static void Oppgave2()
        {
            int a = 5;
            decimal b = 3;
            decimal sum = a + b;
            Console.WriteLine(sum);
           
        }
    }
}
