using HarryPotter;

namespace HarryPotter
{
    internal class Admin
    {
        
        public void RunWizardProgram()
        {
            var hogwarts = new Hogwarts();
            Console.WriteLine("Welcome to the world of wizards!");
            hogwarts.RegisterNewWizard();
            while (true)
            {
                hogwarts.RunHogwartsProgram();
            }
            Console.WriteLine("Congratulations! You finished the wizard program :D");
        }

        
    }
}
