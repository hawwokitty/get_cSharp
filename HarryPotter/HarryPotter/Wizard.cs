namespace HarryPotter
{
    internal class Wizard(string name, string house, string wand, string animal)
    {
        //private string Name = name;
        //private string House = house;
        //private string Wand = wand;
        //private string Animal = animal;
        public string GetWizardInfo()
        {
            string wizardInfo = $"Name: {name}, house: {house}, wand: {wand}, animal: {animal}";
            return wizardInfo;
        }

    }
}
