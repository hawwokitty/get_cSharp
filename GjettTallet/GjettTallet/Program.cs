Random randomNum = new Random();
int NumToGuess = randomNum.Next(1, 100);
Console.WriteLine("Gjett et tall mellom 1 og 100");
int GuessedNumber = Convert.ToInt32(Console.ReadLine());
bool GuessedRight = false;
while (!GuessedRight)
{
if (NumToGuess > GuessedNumber)
{
    Console.WriteLine("Guess higher");
    GuessedNumber = Convert.ToInt32(Console.ReadLine());
} else if (NumToGuess < GuessedNumber)
{
    Console.WriteLine("Guess lower");
    GuessedNumber = Convert.ToInt32(Console.ReadLine());
} else if (NumToGuess == GuessedNumber)
{
    Console.WriteLine("You guessed right :D");
    GuessedRight = true;
}
}