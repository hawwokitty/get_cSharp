namespace Sims
{
    internal class BuildMode
    {
        public void MakeHouse()
        {
            {
                House house = new House();
                bool keepGoing = true;
                while (keepGoing)
                {
                    house.MakeNewHouse();
                    keepGoing = KeepGoingQ();
                }
            }
        }

        private bool KeepGoingQ()
        {
            "Would you like to make another house?".PrintToConsole();
            "1. Make another house".PrintToConsole();
            "2. Back to main menu".PrintToConsole();
            int userInput = "Please enter a number of the menu above:".RequestInt(2);
            bool keepGoing = true;
            switch (userInput)
            {
                case 1: keepGoing = true; break;
                case 2: keepGoing = false; break;
            }
            return keepGoing;
        }
    }
}
