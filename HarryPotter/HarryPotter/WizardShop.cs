namespace HarryPotter
{
    internal class WizardShop
    {
        public List<string> WandTypes = new()
        {
            "Standard Wand",
            "Specialty Wood Wand",
            "Unicorn Hair Core Wand",
            "Dragon Heartstring Core Wand",
            "Phoenix Feather Core Wand",
            "Hybrid Core Wand",
            "Rare Wood Wand",
            "Special Edition Wand",
            "Customized Wand",
            "Antique Wand"
        };
        
    
        public List<string> AnimalsList = new()
        {
            "Owl",
            "Rat",
            "Cat",
            "Toad",
            "Frog",
            "Pygmy Puff",
        };

        private Wizard _currentCustomer;
        public void EnterShop(Wizard wizard)
        {
            _currentCustomer = wizard;
            Console.WriteLine("Welcome to the Wizard Shop! What would you like to buy?");
            Console.WriteLine("1. Buy a wand");
            Console.WriteLine("2. Buy a pet");
            Console.WriteLine("3. Back to hogwarts");
            Console.WriteLine("Please type 1-3");
            PickWhatToDoInShop();
        }

        private void PickWhatToDoInShop()
        {
            bool isValid = false;
            string input = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(input, out int choice) && choice == 1 || choice == 2 || choice == 3)
                {
                    if (choice == 1)
                    {
                        GetWand();
                    }
                    else if (choice == 2)
                    {
                        GetAnimal();
                    }else if (choice == 3)
                    {
                        break;
                    }
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    input = Console.ReadLine();
                }
            }
        }

        private void GetAnimal()
        {
            Console.WriteLine("You may now buy an animal! Please pick your animal:");
            for (int i = 0; i < AnimalsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {AnimalsList[i]}");
            }
            Console.WriteLine($"Please type 1-{AnimalsList.Count}:");
            string animal = RunGetAnimal();
            _currentCustomer.SetAnimal(animal);
            Console.WriteLine($"You now own: {animal}");
            EnterShop(_currentCustomer);


        }

        private void GetWand()
        {
            Console.WriteLine("You can now buy a wand here in the shop. Please pick the wand you would like:");
            for (int i = 0; i < WandTypes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {WandTypes[i]}");
            }
            Console.WriteLine($"Please type 1-{WandTypes.Count}:");
            string wand = RunGetWand();
            _currentCustomer.SetWand(wand);
            Console.WriteLine($"You now have a: {wand}");
            EnterShop(_currentCustomer);
        }

        string RunGetWand()
        {
            string wand = "";
            bool isValid = false;
            string wandInput = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(wandInput, out int wandIndex) && wandIndex >= 1 && wandIndex <= WandTypes.Count)
                {
                    wandIndex -= 1;
                    wand = WandTypes[wandIndex];
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid wand selection. Please try again.");
                    wandInput = Console.ReadLine();
                }
            }
            return wand;
        }
        string RunGetAnimal()
        {
            string animal = "";
            bool isValid = false;
            string animalInput = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(animalInput, out int animalIndex) && animalIndex >= 1 && animalIndex <= AnimalsList.Count)
                {
                    animalIndex -= 1;
                    animal = AnimalsList[animalIndex];
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid animal selection. Please try again.");
                    animalInput = Console.ReadLine();
                }
            }

            return animal;
        }
    }
    
}
