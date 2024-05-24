namespace HarryPotter
{
    internal class Magic
    {
        List<string> _harryPotterSpells = new List<string>
        {
            "Expelliarmus",     // Disarming Charm
            "Lumos",            // Light-producing Charm
            "Alohomora",        // Unlocking Charm
            "Accio",            // Summoning Charm
            "Stupefy",          // Stunning Spell
            "Wingardium Leviosa", // Levitation Charm
            "Expecto Patronum", // Patronus Charm
            "Protego",          // Shield Charm
            "Avada Kedavra",    // Killing Curse
            "Crucio"            // Cruciatus Curse
        };

        public void PerformMagicSpell(string spell)
        {
            string performSpell = _harryPotterSpells.Find(s => s.ToLower() == spell.ToLower());
            if (performSpell != null)
            {
                Console.WriteLine($"You performed {performSpell}");
            }
            else
            {
                Console.WriteLine("You did not enter a valid spell! Please try again:");
                spell = Console.ReadLine();
                PerformMagicSpell(spell);
            }
        }
    }
}
