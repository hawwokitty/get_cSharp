namespace TextAdventure
{
    internal class Room
    {
        protected string Name { get; set; }
        protected List<Task> _listOfTasks = new List<Task>();

        public virtual void SetTasks() { }

        public Task FindTask(string userInput, string title)
        {
            foreach (var task in _listOfTasks)
            {
                foreach (var keyword in task.KeyWords)
                {
                    if (userInput.Contains(keyword, StringComparison.OrdinalIgnoreCase) && task.Title == title)
                    {
                        return task;
                    }
                }
            }
            return null;  // No matching task found
        }
    }
}