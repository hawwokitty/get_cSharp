namespace HarryPotter
{
    internal class Wizard(string name, string house, string wand, string animal)
    {
        public Wizard(string name, string house)
            : this(name, house, "None", "None")
        {
        }

        public string Name { get; private set; } = name;
        public string House { get; private set; } = house;
        public string Wand { get; private set; } = wand;
        public string Animal { get; private set; } = animal;

        public string GetWizardInfo()
        {
            string wizardInfo = $"\nName: {Name} \nHouse: {House} \nWand: {Wand}\nAnimal: {Animal}";
            return wizardInfo;
        }

        public void SetAnimal(string animal)
        {
            Animal = animal;
        }
        public void SetWand(string wand)
        {
            Wand = wand;
        }

    }
}
