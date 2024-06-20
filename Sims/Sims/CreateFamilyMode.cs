namespace Sims
{
    internal class CreateFamilyMode
    {
        public void CreateFamily()
        {
            FamilyMember family = new FamilyMember();
            bool keepGoing = true;
            while (keepGoing)
            {
                family.CreateFamilyMember();
                keepGoing = KeepGoingQ();
            }
        }

        private bool KeepGoingQ()
        {
            "Would you like to make another family member?".PrintToConsole();
            "1. Make another family member".PrintToConsole();
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
