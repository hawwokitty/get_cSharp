using HarryPotter;

namespace HarryPotter
{
    internal class Admin
    {
        public List<string> HouseList = new()
        {
            "Hufflepuff",
            "Gryffindor",
            "Slytherin",
            "Ravenclaw",
        };
        public void RunWizardProgram()
        {
            var wizardShop = new WizardShop();
            Console.WriteLine("Welcome to the world of wizards!");
            Console.WriteLine("Let's go ahead and register you in the system! In order to do so we just need to know a few things:");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Which house do you belong to?");
            for (int i = 0; i < HouseList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {HouseList[i]}");
            }
            Console.WriteLine($"Please type 1-{HouseList.Count}:");
            string house = RunGetHouse();
            Console.WriteLine($"You picked: {house}");
            Console.WriteLine("You can now buy a wand here in the shop. Please pick the wand you would like:");
            for (int i = 0; i < wizardShop.WandTypes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {wizardShop.WandTypes[i]}");
            }
            Console.WriteLine($"Please type 1-{wizardShop.WandTypes.Count}:");
            string wand = RunGetWand(wizardShop);
            Console.WriteLine($"You picked: {wand}");
            Console.WriteLine("You may now buy an animal! Please pick your animal:");
            for (int i = 0; i < wizardShop.AnimalsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {wizardShop.AnimalsList[i]}");
            }
            Console.WriteLine($"Please type 1-{wizardShop.AnimalsList.Count}:");
            string animal = RunGetAnimal(wizardShop);
            Console.WriteLine($"You picked: {animal}");
            Wizard wizard = new Wizard(name, house, wand, animal);
            string wizardInfo = wizard.GetWizardInfo();
            Console.WriteLine($"Now this is you: {wizardInfo}");
            Console.WriteLine("Would you like to perform magic spells? Go ahead and type a spell and see if you are able!");
            string inputSpell = Console.ReadLine();
            var magic = new Magic();
            magic.PerformMagicSpell(inputSpell);
            Console.WriteLine("Congratulations! You finished the wizard program :D");

        }

        string RunGetWand(WizardShop shop)
        {
            string wand = "";
            bool isValid = false;
            string wandInput = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(wandInput, out int wandIndex) && wandIndex >= 1 && wandIndex <= shop.WandTypes.Count)
                {
                    wandIndex -= 1;
                    wand = shop.WandTypes[wandIndex];
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
        string RunGetAnimal(WizardShop shop)
        {
            string animal = "";
            bool isValid = false;
            string animalInput = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(animalInput, out int animalIndex) && animalIndex >= 1 && animalIndex <= shop.AnimalsList.Count)
                {
                    animalIndex -= 1;
                    animal = shop.AnimalsList[animalIndex];
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

        string RunGetHouse()
        {
            string house = "";
            bool isValid = false;
            string houseInput = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(houseInput, out int houseIndex) && houseIndex >= 1 && houseIndex <= HouseList.Count)
                {
                    houseIndex -= 1;
                    house = HouseList[houseIndex];
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid house selection. Please try again."); 
                    houseInput = Console.ReadLine();
                }
            }


            return house;
        }
    }
}
