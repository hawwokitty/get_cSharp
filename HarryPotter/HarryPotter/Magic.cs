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
            string performSpell = "";
            for (int i = 0; i < _harryPotterSpells.Count; i++)
            {
                if (spell.ToLower() == _harryPotterSpells[i].ToLower())
                {
                    performSpell = $"You performed {_harryPotterSpells[i]}!";
                    break;
                }
                else
                {
                    performSpell = "You did not enter a valid spell!";
                }
            }
            Console.WriteLine(performSpell);
        }
    }
}
