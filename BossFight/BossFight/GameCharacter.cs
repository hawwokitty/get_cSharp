namespace BossFight
{
    internal class GameCharacter(string type, int health, int strength, int stamina)
    {
        public string Type { get; private set; } = type;
        public int Health { get; private set; } = health;
        public int Strength { get; private set; } = strength;
        public int Stamina { get; private set; } = stamina;

        public void Fight(GameCharacter characterBeingAttacked)
        {
            if (Type == "Boss")
            {
                Random randomNum = new Random();
                Strength = randomNum.Next(0, 20);
            }
            if (Stamina > 0)
            {
                characterBeingAttacked.Health = characterBeingAttacked.Health - Strength;
                Stamina -= 10;
                Console.WriteLine($"{Type} hit {characterBeingAttacked.Type} for {Strength} damage, {characterBeingAttacked.Type} now has {characterBeingAttacked.Health} left");
            }
            else
            {
                Console.WriteLine($"{Type} had to recharge this turn");
                Recharge();
            }
        }

        public void Recharge()
        {
            Stamina = stamina;
        }
    }
}
