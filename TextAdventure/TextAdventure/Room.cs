namespace TextAdventure
{
    internal class Room
    {
        protected string Name { get; set; }
        protected List<Task> _listOfTasks = new List<Task>();

        public Room(string name)
        {
            Name = name;
            SetTasks();
        }

        protected virtual void SetTasks()
        {
            // This method will be overridden in derived classes to set specific tasks
        }

        public void DisplayTasks(ConsoleLines console)
        {
            console.PrintLine($"You are in the {Name}. What would you like to do?");
            for (int i = 0; i < _listOfTasks.Count; i++)
            {
                console.PrintLine($"{i + 1}. {_listOfTasks[i].Choice}");
            }
        }

        public void PerformTask(int taskNumber, ConsoleLines console)
        {
            if (taskNumber >= 1 && taskNumber <= _listOfTasks.Count)
            {
                _listOfTasks[taskNumber - 1].DoTask();
            }
            else
            {
                console.PrintLine("Invalid choice. Try again.");
            }
        }
    }
}