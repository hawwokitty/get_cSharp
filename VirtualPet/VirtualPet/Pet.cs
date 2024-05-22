namespace VirtualPet
{
    internal class Pet(string name, int age, bool isHungry, bool isPoopy, bool isCuddly)
    {
        public string Name { get; private set; } = name;
        public int Age { get; private set; } = age;
        public bool IsHungry { get; private set; } = isHungry;
        public bool IsPoopy { get; private set; } = isPoopy;
        public bool IsCuddly { get; private set; } = isCuddly;

        public void RunShowPetCareOptions()
        {
            Console.WriteLine("Pick an option:");
            Console.WriteLine($"1. Feed {Name}");
            Console.WriteLine($"2. Potty {Name}");
            Console.WriteLine($"3. Cuddle {Name}");
            int input = Convert.ToInt32(Console.ReadLine());
            RunPickedOption(input);
        }

        public void RunPickedOption(int input)
        {
            switch (input)
            {
                case 1: RunOption1();
                    break;
                case 2: RunOption2();
                    break;
                case 3: RunOption3();
                    break;
                default: Console.WriteLine("Please pick a valid option"); RunShowPetCareOptions();
                    break;
            }
        }

        public void RunOption1()
        {
            if (IsHungry)
            {
                Console.WriteLine($"You fed {Name}");
                IsHungry = false;
                IsPoopy = true; // senere gjøre denne random.
                IsCuddly = true;
            }
            else
            {
                Console.WriteLine($"{Name} was not hungry");
                RunShowPetCareOptions();
            }
        }
        public void RunOption2()
        {
            if (IsPoopy)
            {
                Console.WriteLine($"You took {Name} to use the bathroom");
                IsPoopy = false;
                IsHungry = true; // senere gjøre denne random.
                IsCuddly = true;
            }
            else
            {
                Console.WriteLine($"{Name} did not need to use the bathroom");
                RunShowPetCareOptions();
            }
        } 
        public void RunOption3()
        {
            if (IsCuddly)
            {
                Console.WriteLine($"You cuddled {Name}");
                IsCuddly = false;
                IsHungry = true; // senere gjøre denne random.
                IsPoopy = true;
            }
            else
            {
                Console.WriteLine($"{Name} did not want to be cuddled");
                RunShowPetCareOptions();
            }
        }


    }
}
