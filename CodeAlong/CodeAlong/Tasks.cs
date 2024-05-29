namespace CodeAlong
{
    internal class Tasks()
    {
        private string TaskTitle { get; set; }
        private string Time { get; set; }
        private List<Tasks> _listOfTasks = new ();
        private bool _IsRunning = true;

        public Tasks(string task, string time) : this()
        {
            TaskTitle = task;
            Time = time;
        }

        private void ShowAllTasks()
        {
            for (int i = 0; i < _listOfTasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_listOfTasks[i].TaskTitle}");
            }
        }

        private void ShowTasksOfTheDay()
        {

        }

        private void AddTaskToList(Tasks task)
        {
            _listOfTasks.Add(task);
        }

        private void AddNewTask()
        {
            Console.WriteLine("Please write out your new task:");
            string newTask = Console.ReadLine();
            Console.WriteLine("Please enter the due date of the task:");
            string newTaskDate = Console.ReadLine();
            Tasks task = new Tasks(newTask, newTaskDate);
            Console.WriteLine("You have successfully added the task :D");
            AddTaskToList(task);
        }

        public void RunTaskProgram()
        {
            while (_IsRunning)
            {
                PickMenuChoice();
            }
        }
        private void PickMenuChoice()
        {
            Console.WriteLine("Please pick what you would like to do (1-3):");
            ShowMenu();
            bool isValid = false;
            string input = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(input, out int choice) && choice == 1 || choice == 2 || choice == 3 || choice == 4)
                {
                    if (choice == 1)
                    {
                        ShowAllTasks();
                    }
                    else if (choice == 2)
                    {
                        AddNewTask();
                    }
                    else if (choice == 3)
                    {
                        ShowTasksOfTheDay();
                    }
                    else if (choice == 4)
                    {
                        _IsRunning = false;
                    }
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    input = Console.ReadLine();
                }
            }

        }

        private void ShowMenu()
        {
            Console.WriteLine("1. Show all tasks");
            Console.WriteLine("2. Add new Task");
            Console.WriteLine("3. Get tasks for day");
            Console.WriteLine("4. Exit");
        }
    }
}
