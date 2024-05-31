namespace Sims
{
    internal class FamilyMember
    {
        private string? FirstName { get; set; }
        private string? LastName { get; set;}
        private bool IsAdult { get; set; } 
        private string? Gender { get; set;}

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
            string? newFirstName = GetName("What is the character's first name?");
            string? newLastName = GetName("What is the character's last name?");
            bool newIsAdult = GetIsAdult();
            string newGender = GetGender();
            FamilyMember familyMember = new FamilyMember(newFirstName, newLastName, newIsAdult, newGender);
        }

        private string GetGender()
        {
            Console.WriteLine("The character is:");
            Console.WriteLine("1. Male");
            Console.WriteLine("2. Female");
            Console.WriteLine("3. Other");
            bool isValid = false;
            string newGender = "";
            string? input = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(input, out int choice) && choice == 1 || choice == 2)
                {
                    if (choice == 1)
                    {
                        newGender = "Male";
                    }
                    else
                    {
                        newGender = "Female";
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
            string? input = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(input, out int choice) && choice == 1 || choice == 2)
                {
                    if (choice == 1)
                    {
                        newIsAdult = true;
                    }
                    else
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

        private string? GetName(string question)
        {
            Console.WriteLine(question);
            string? name = Console.ReadLine();
            return name;
        }

    }
}
