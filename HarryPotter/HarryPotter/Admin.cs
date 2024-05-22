using HarryPotter;

namespace HarryPotter
{
    internal class Admin
    {
        public void RunWizardProgram()
        {
            var wizardShop = new WizardShop();
            Console.WriteLine("Welcome to the world of wizards!");
            Console.WriteLine("Let's go ahead and register you in the system! In order to do so we just need to know a few things:");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Which house do you belong to?");
            Console.WriteLine("1. Hufflepuff");
            Console.WriteLine("2. Gryffindor");
            Console.WriteLine("3. Slytherin");
            Console.WriteLine("4. Ravenclaw");
            Console.WriteLine("Please type 1-4:");
            var houseInput = Console.ReadLine();
            string house = RunGetHouse(houseInput);
            Console.WriteLine($"You picked: {house}");
            Console.WriteLine("You can now buy a wand here in the shop. Please pick the wand you would like:");
            for (int i = 0; i < wizardShop._wandTypes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {wizardShop._wandTypes[i]}");
            }
            Console.WriteLine("Please type 1-10:");
            int wandInput = Convert.ToInt32(Console.ReadLine());
            string wand = RunGetWand(wandInput, wizardShop);
            Console.WriteLine($"You picked: {wand}");
            Console.WriteLine("You may now buy an animal! Please pick your animal:");
            for (int i = 0; i < wizardShop._animalsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {wizardShop._animalsList[i]}");
            }
            Console.WriteLine("Please type 1-10:");
            int animalInput = Convert.ToInt32(Console.ReadLine());
            string animal = RunGetAnimal(animalInput, wizardShop);
            Console.WriteLine($"You picked: {animal}");
            Wizard wizard = new Wizard(name, house, wand, animal);
            string wizardInfo = wizard.GetWizardInfo();
            Console.WriteLine($"Now this is you: {wizardInfo}");
            Console.WriteLine("Would you like to perform magic spells? Go ahead and type a spell and see if you are able!");
            string inputSpell = Console.ReadLine();
            var magic = new Magic();
            magic.PerformMagicSpell(inputSpell);

        }

        string RunGetWand(int wandInput, WizardShop shop)
        {
            if (wandInput >= 1 && wandInput <= shop._wandTypes.Count)
            {
                return shop._wandTypes[wandInput - 1];
            }
            else
            {
                Console.WriteLine("Invalid wand selection. Please try again.");
                return null;
            }
        }
        string RunGetAnimal(int animalInput, WizardShop shop)
        {
            if (animalInput >= 1 && animalInput <= shop._animalsList.Count)
            {
                return shop._animalsList[animalInput - 1];
            }
            else
            {
                Console.WriteLine("Invalid animal selection. Please try again.");
                return null;
            }
        }

        string RunGetHouse(string houseInput)
        {
            string house = null;
            bool validInput = false;

            while (!validInput)
            {
                switch (houseInput)
                {
                    case "1":
                        house = "Hufflepuff";
                        validInput = true;
                        break;
                    case "2":
                        house = "Gryffindor";
                        validInput = true;
                        break;
                    case "3":
                        house = "Slytherin";
                        validInput = true;
                        break;
                    case "4":
                        house = "Ravenclaw";
                        validInput = true;
                        break;
                    default:
                        Console.WriteLine("That's an invalid number, please try again. Please type 1-4:");
                        houseInput = Console.ReadLine();
                        break;
                }
            }

            return house;
        }
    }
}
