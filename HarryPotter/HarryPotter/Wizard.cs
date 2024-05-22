namespace HarryPotter
{
    internal class Wizard(string name, string house, string wand, string animal)
    {
        public string GetWizardInfo()
        {
            string wizardInfo = $"\nName: {name} \nHouse: {house} \nWand: {wand}\nAnimal: {animal}";
            return wizardInfo;
        }

    }
}
