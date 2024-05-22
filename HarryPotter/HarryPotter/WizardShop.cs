namespace HarryPotter
{
    internal class WizardShop
    {
        public readonly List<string> _wandTypes = InitializeWandTypesList();
        public readonly List<string> _animalsList = InitializeAnimalsList();

        private static List<string> InitializeWandTypesList()
        {
        return new List<string>
        {
            "Standard Wand",
            "Specialty Wood Wands",
            "Unicorn Hair Core Wands",
            "Dragon Heartstring Core Wands",
            "Phoenix Feather Core Wands",
            "Hybrid Core Wands",
            "Rare Wood Wands",
            "Special Edition Wands",
            "Customized Wands",
            "Antique Wands"
        };
        }private static List<string> InitializeAnimalsList()
        {
        return new List<string>
        {
            "Owl",
            "Rat",
            "Cat",
            "Toad",
            "Frog",
            "Pygmy Puff",
        };
        }
    }
}
