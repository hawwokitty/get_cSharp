namespace HarryPotter
{
    internal class Hogwarts
    {
        private List<Wizard> _wizards = new()
        {
            new Wizard("Harry Potter", "Gryffindor", "Phoenix Feather Core Wand", "Owl"),
            new Wizard("Hermione Granger", "Gryffindor", "Dragon Heartstring Core Wand", "Cat"),
            new Wizard("Ron Weasley", "Gryffindor", "Unicorn Hair Core Wand", "Rat"),
            new Wizard("Draco Malfoy", "Slytherin", "Unicorn Hair Core Wand", "Eagle Owl"),
            new Wizard("Luna Lovegood", "Ravenclaw", "Unicorn Hair Core Wand", "Rabbit"),
            new Wizard("Cedric Diggory", "Hufflepuff", "Unicorn Hair Core Wand", "Owl"),
        };

        private List<string> _houseList = new()
        {
            "Hufflepuff",
            "Gryffindor",
            "Slytherin",
            "Ravenclaw",
        };

        private Wizard _currentWizard;

        public void RegisterNewWizard()
        {
            Console.WriteLine("Let's go ahead and register you in the system! In order to do so we just need to know a few things:");
            string name = GetName();
            var house = GetHouse();
            Wizard wizard = new Wizard(name, house);
            _currentWizard = wizard;
            var wizardInfo = MakeIntoWizard(wizard);
            Console.WriteLine($"Now this is you: {wizardInfo}");
            Console.WriteLine("Amazing! Now we can enter the Wizard Shop!");
            WizardShop shop = new WizardShop();
            shop.EnterShop(wizard);
        }


        private string MakeIntoWizard(Wizard wizard)
        {
            string wizardInfo = wizard.GetWizardInfo();
            _wizards.Add(wizard);
            return wizardInfo;
        }

        

        private string GetHouse()
        {
            Console.WriteLine("Which house do you belong to?");
            for (int i = 0; i < _houseList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_houseList[i]}");
            }
            Console.WriteLine($"Please type 1-{_houseList.Count}:");
            string house = RunGetHouse();
            Console.WriteLine($"You picked: {house}");
            return house;
        }

        private string? GetName()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            return name;
        }

        

        string RunGetHouse()
        {
            string house = "";
            bool isValid = false;
            string houseInput = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(houseInput, out int houseIndex) && houseIndex >= 1 && houseIndex <= _houseList.Count)
                {
                    houseIndex -= 1;
                    house = _houseList[houseIndex];
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

        public List<Wizard> GetWizardsList()
        {
            return _wizards;
        }

        public void RunHogwartsProgram()
        {
            var magic = new Magic();
            PerformSpells(magic);
        }
        public void PerformSpells(Magic magic)
        {
            Console.WriteLine("Would you like to perform magic spells? Go ahead and type a spell and see if you are able!");
            string inputSpell = Console.ReadLine();
            magic.PerformMagicSpell(inputSpell, _currentWizard);
            
        }
    }

}
