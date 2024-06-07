namespace TextAdventure
{
    internal class Game
    {
        protected ConsoleLines console = new ConsoleLines();
        private Bedroom bedroom = new Bedroom();
        private Kitchen kitchen = new Kitchen();
        private LivingRoom livingRoom = new LivingRoom();
        private Bathroom bathroom = new Bathroom();

        public void Run()
        {
            console.PrintLine("Welcome! Press enter to start the game.");
            console.ReadLine();
            PlayGame();
        }

        private void PlayGame()
        {
            while (true)
            {
                console.PrintLine("Choose a room to enter:");
                console.PrintLine("1. Bedroom");
                console.PrintLine("2. Kitchen");
                console.PrintLine("3. Living Room");
                console.PrintLine("4. Bathroom");

                if (int.TryParse(console.ReadLine(), out int roomChoice))
                {
                    switch (roomChoice)
                    {
                        case 1:
                            bedroom.DisplayTasks(console);
                            break;
                        case 2:
                            kitchen.DisplayTasks(console);
                            break;
                        case 3:
                            livingRoom.DisplayTasks(console);
                            break;
                        case 4:
                            bathroom.DisplayTasks(console);
                            break;
                        default:
                            console.PrintLine("Invalid room choice. Try again.");
                            continue;
                    }

                    console.PrintLine("Enter your choice:");
                    if (int.TryParse(console.ReadLine(), out int taskChoice))
                    {
                        switch (roomChoice)
                        {
                            case 1:
                                bedroom.PerformTask(taskChoice, console);
                                break;
                            case 2:
                                kitchen.PerformTask(taskChoice, console);
                                break;
                            case 3:
                                livingRoom.PerformTask(taskChoice, console);
                                break;
                            case 4:
                                bathroom.PerformTask(taskChoice, console);
                                break;
                        }
                    }
                    else
                    {
                        console.PrintLine("Invalid input. Please enter a number.");
                    }
                }
                else
                {
                    console.PrintLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
