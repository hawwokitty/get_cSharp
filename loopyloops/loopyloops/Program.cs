namespace loopyloops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tall = 1;
            while (tall < 11)
            {
                Console.WriteLine($"Runde nr {tall}");
                tall++;
            }

        }
    }
}

/*
 oppgave 1:
 for (int i = 0; i < 5; i++)
   {
       Console.WriteLine("Terje er kul");
   }

oppgave 2:
string alfabetet = "abcdefghijklmnopqsrtuvwxyzæøå";
   foreach (char letter in alfabetet)
   {
       Console.WriteLine(letter);
   }
 */