namespace Sims
{
    internal class FamilyMember(string firstName, string lastName, bool isAdult, string gender)
    {
        public string FirstName { get; private set; } = firstName;
        public string LastName { get; private set;} = lastName;
        public bool IsAdult { get; private set; } = isAdult;
        public string Gender { get; private set;} = gender;

        public FamilyMember() : this("None", "None", false, "None")
        {
            
        }

        public void CreateFamilyMember()
        {
            string newFirstName = GetFirstName();
            string newLastName = GetLastName();
            bool newIsAdult = GetIsAdult();
            string newGender = GetGender();
        }

        private string GetGender()
        {
            Console.WriteLine("The character is:");
            Console.WriteLine("1. Male");
            Console.WriteLine("2. Female");
            Console.WriteLine("3. Other");
            bool isValid = false;
            string newGender = "";
            string input = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(input, out int choice) && choice == 1 || choice == 2)
                {
                    if (choice == 1)
                    {
                        newGender = "Male";
                    }
                    else if (choice == 2)
                    {
                        newGender = "Female";
                    }
                    else if (choice == 3)
                    {
                        newGender = "Other";
                    }
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    input = Console.ReadLine();
                }
            }
            return newGender;
        }

        private bool GetIsAdult()
        {
            Console.WriteLine("The character is:");
            Console.WriteLine("1. An adult");
            Console.WriteLine("2. A child");
            bool isValid = false;
            bool newIsAdult = false;
            string input = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(input, out int choice) && choice == 1 || choice == 2)
                {
                    if (choice == 1)
                    {
                        newIsAdult = true;
                    }
                    else if (choice == 2)
                    {
                        newIsAdult = false;
                    }
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    input = Console.ReadLine();
                }
            }

            return newIsAdult;
        }

        private string GetLastName()
        {
            Console.WriteLine("What is the characters last name?");
            string newLastName = Console.ReadLine();
            return newLastName;
        }

        private string GetFirstName()
        {
            Console.WriteLine("What is the characters first name?");
            string newFirstName = Console.ReadLine();
            return newFirstName; 
        }
    }
}
