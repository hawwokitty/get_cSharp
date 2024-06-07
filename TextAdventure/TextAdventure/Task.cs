namespace TextAdventure
{
    internal class Task
    {
        protected string Title { get; set; }
        public string Choice { get; private set; }
        protected string Description { get; set; }
        protected string[] KeyWords { get; set; }

        public Task(string title, string choice, string description, params string[] keyWords)
        {
            Title = title;
            Choice = choice;
            Description = description;
            KeyWords = keyWords;
        }

        public virtual void DoTask()
        {
            Console.WriteLine(Description);
        }
    }
}