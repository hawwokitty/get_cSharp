namespace Sims
{
    internal class FamilyMember
    {
        private string? FirstName { get; set; }
        private string? LastName { get; set; }
        private bool IsAdult { get; set; }
        private string? Gender { get; set; }

        public FamilyMember(string? firstName, string? lastName, bool isAdult, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            IsAdult = isAdult;
            Gender = gender;
        }

        public FamilyMember()
        {

        }

        public void CreateFamilyMember()
        {
            string? newFirstName = "What is the character's first name?".RequestString();
            string? newLastName = "What is the character's last name?".RequestString();
            bool newIsAdult = GetIsAdult();
            string newGender = GetGender();
            FamilyMember familyMember = new FamilyMember(newFirstName, newLastName, newIsAdult, newGender);
            $"You created a new family member called {newFirstName}".PrintToConsole();
        }

        private string GetGender()
        {
            Console.WriteLine("The character is:");
            Console.WriteLine("1. Male");
            Console.WriteLine("2. Female");
            Console.WriteLine("3. Other");
            string gender = "";
            int userInput = "Please enter a number of the menu above:".RequestInt(3);
            switch (userInput)
            {
                case 1:
                    gender = "Male";
                    break;
                case 2:
                    gender = "Female";
                    break;
                case 3:
                    gender = "Other";
                    break;
            }
            return gender;
        }

        private bool GetIsAdult()
        {
            Console.WriteLine("The character is:");
            Console.WriteLine("1. An adult");
            Console.WriteLine("2. A child");
            bool isAdult = false;
            int userInput = "Please enter a number of the menu above:".RequestInt(2);
            switch (userInput)
            {
                case 1:
                    isAdult = true;
                    break;
                case 2:
                    IsAdult = false;
                    break;
            }

            return isAdult;
        }

    }
}
