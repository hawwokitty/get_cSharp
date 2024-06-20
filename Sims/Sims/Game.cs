namespace Sims
{
    internal class Game
    {
        public void Run()
        {
            var createFamily = new CreateFamilyMode();
            var buildHouse = new BuildMode();
            while (true)
            {
                "Hello, welcome to The sims 0.000420!".PrintToConsole();
                "What would you like to do?".PrintToConsole();
                ShowMenu();
                int userChoice = "Please enter a number of the menu above:".RequestInt(3);
                switch (userChoice)
                {
                    case 1:
                        createFamily.CreateFamily();
                        break;
                    case 2:
                        buildHouse.MakeHouse();
                        break;
                    case 3:
                        Play();
                        break;
                }
            }
        }

        private void Play()
        {
            throw new NotImplementedException();
        }

        private void ShowMenu()
        {
            "1. Create Family".PrintToConsole();
            "2. Make House".PrintToConsole();
            "3. Pick a Family to Play as".PrintToConsole();
        }
    }
}
