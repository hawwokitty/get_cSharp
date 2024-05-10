
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Would you like to 1. reverse a word/sentence OR 2. change a letter in a word/sentence?");
int answer = Convert.ToInt32(Console.ReadLine());
if (answer == 1)
{
    Console.WriteLine("Ok, please type the word/sentence you would like to reverse");
    string input = Console.ReadLine();
    char[] array = input.ToCharArray();
    Array.Reverse(array);
    string output = new String(array);
    Console.WriteLine($"The reverse of what you wrote is: {output}");
} else if (answer == 2)
{
    Console.WriteLine("Ok, please type the word/sentence you would like to modify");
    string input = Console.ReadLine();
    Console.WriteLine("Please type which letter you would like to change");
    char letterToChange = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Please type which letter you would like to replace it with");
    char letterReplaceWith = Convert.ToChar(Console.ReadLine());
    char[] arrayOfInput = input.ToCharArray();
    arrayOfInput[Array.IndexOf(arrayOfInput, letterToChange)] = letterReplaceWith;
    string output = new String(arrayOfInput);
    Console.WriteLine($"The new text is now: {output}");
}