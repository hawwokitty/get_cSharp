namespace TextAdventure
{
    internal class Game
    {
        protected ConsoleLines console = new ConsoleLines();

        public void Run()
        {
            console.PrintLine("Welcome! Press enter to start the game.");
            console.ReadLine();
            PlayGame();
        }

        private void PlayGame()
        {
            RunBedroom();
        }

        private void RunBedroom()
        {
            Room room = new Bedroom();  // Use Bedroom for now
            room.SetTasks();  // Initialize tasks for the room
            console.PrintLine("You wake up in your bed for the 4th time this night, a little bit of light shines through your blinds letting you know it's probably morning. You're already dreading the day ahead but you need to make a choice, what do you do?");

            bool canProgress = false;
            while (!canProgress)
            {
                canProgress = DoUserChoice(room, "Wake Up in Bed");
                if (!canProgress)
                {
                    console.PrintLine("That didn't get you far, what else would you like to try?");
                }
            }

            console.PrintLine("You manage to sleep for a little while longer, however you feel just as drained as before. This time when you wake up again you're ready to get on with your day, which room would you like to go to?");
            bool canExitRoom = false;
            while (!canExitRoom)
            {
                canExitRoom = DoUserChoice(room, "Move rooms");
                if (!canExitRoom)
                {
                    console.PrintLine("You still need to choose a room. What would you like to do?");
                }
            }
        }

        private bool DoUserChoice(Room room, string title)
        {
            Task choice = null;
            while (choice == null)
            {
                string userInput = console.ReadLine();
                choice = room.FindTask(userInput, title);

                if (choice == null)
                {
                    console.PrintLine("That's not a valid action. Please try again.");
                }
            }
            choice.DoTask();
            return choice.CanProgress;
        }
    }
}