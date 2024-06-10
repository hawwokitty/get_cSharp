using System;
using System.Text;

namespace UnicodeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set the console to use UTF-8 encoding
            Console.OutputEncoding = Encoding.UTF8;

            string frogEmojiDirect = "🐸";
            string frogEmojiUnicode = "\U0001F438";

            Console.WriteLine("Here is a frog emoji (direct): " + frogEmojiDirect);
            Console.WriteLine("Here is a frog emoji (unicode): " + frogEmojiUnicode);
        }
    }
}