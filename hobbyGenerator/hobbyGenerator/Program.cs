namespace hobbyGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the name of the person who would like a new hobby:");
            string nameOfPerson = Console.ReadLine();
            string hobby = GetRandomHobby();
            Console.WriteLine($"{nameOfPerson}'s new hobby is now: {hobby}");
        }

        public static string GetRandomHobby()
        {
            Random rand = new Random();
            string[] hobbies = { "Cosplay", "Cooking", "Painting", "Assassin", "Wolf-tamer" };
            int randomNumber = rand.Next(hobbies.Length + 1);
            string newHobby = hobbies[randomNumber];
            return newHobby;
        }
    }
}
