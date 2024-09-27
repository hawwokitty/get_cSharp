namespace GjesteBok1
{
    internal class Book
    {
        public void Run()
        {
            Welcome();
            while (true)
            {
                Menu();
            }
        }

        private void Welcome()
        {
            "Welcome to the Guestbook!".PrintToConsole();
        }

        private void Menu()
        {
            "What would you like to do?".PrintToConsole();
            "1. Enter a party".PrintToConsole();
            "2. Search for a guest".PrintToConsole();
            int userInput = "Please enter a number from the menu above".RequestInt(2);
            switch (userInput)
            {
                case 1: AddParty(); break;
                case 2: SearchGuests(); break;
            }
        }

        private void AddParty()
        {
            Guest.AddNewParty();
            AddGuest();
            ShowParty();
        }

        private void SearchGuests()
        {
            "How would you like to search?".PrintToConsole();
            "1. Search specific name".PrintToConsole();
            "2. Search name containing letter".PrintToConsole();
            "3. Search name starting with letter".PrintToConsole();
            "4. Search name ending with letter".PrintToConsole();
            int userInput = "Please enter a number from the menu above".RequestInt(4);
        }

        private void AddGuest()
        {
            string name = "Please enter the full name of the person you are signing up:".RequestString();
            Guest newGuest = new Guest(name);
            $"Successfully added {name}".PrintToConsole();
            AddMore();
        }

        private void ShowParty()
        {
            Guest.ShowParty();
        }

        private void AddMore()
        {
            bool AddMore = "Would you like to add more people?".RequestBool();
            if (AddMore)
            {
                AddGuest();
            }
        }
    }
}
