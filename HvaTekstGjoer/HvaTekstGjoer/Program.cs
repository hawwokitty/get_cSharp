var range = 250;
var counts = new int[range];
var total = 0;
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine().ToUpper();
    
    foreach (var character in text ?? string.Empty)
    {
        counts[(int)character]++;
        total++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            int amount = counts[i];
            var percentage = (amount / (double)total) * 100;
            string output = character + " - " + Math.Round(percentage, 2) + "%";
            Console.CursorLeft = Console.BufferWidth - output.Length;
            Console.WriteLine(output);
        }
    }
}