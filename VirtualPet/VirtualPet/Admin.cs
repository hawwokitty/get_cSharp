namespace VirtualPet
{
    internal class Admin
    {
        private List<Pet> _pets = new List<Pet>()
        {
            new("Nico", 7, false, true, true),
            new("Bianca", 3, true, false, false),
        };

        public void RunVirtualPetProgram()
        {
            Console.WriteLine("Welcome to Virtual Pet!");
            Console.WriteLine("Which pet would you like to take care of?");
            RunShowPets();
            Pet pickedPet = RunPickPet();
            Console.WriteLine($"You picked: {pickedPet.Name}");
            pickedPet.RunShowPetCareOptions();

        }

        private void RunShowPets()
        {
            for (int i = 0; i < _pets.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_pets[i].Name}");
            }

        }

        private Pet RunPickPet()
        {
            Console.WriteLine("Please type the number of the pet:");
            int input = Convert.ToInt32(Console.ReadLine());
            return _pets.Where(p => p.Name == _pets[input - 1].Name).FirstOrDefault();
        }

        
    }
}
