using System.Drawing;

namespace Abaxrekruttering
{
    internal class Boat : ITransportation
    {
        public int MaxSpeedInKnop { get; set; }
        public int GrossTonnageInKg { get; set; }
        public string Type { get; set; }
        public string Identifier { get; set; }
        public int EffectInKw { get; set; }
        public void Operate()
        {
            Console.WriteLine($"Båt {Identifier} kjører");

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Kjennetegn: {Identifier}");
            Console.WriteLine($"Maksfart: {MaxSpeedInKnop} knop");
            Console.WriteLine($"Effekt: {EffectInKw} kw");
            Console.WriteLine($"Bruttonasje: {GrossTonnageInKg} kg");
            Console.WriteLine($"Type: {Type}");
        }

        public Boat(int maxSpeedInKnop, int grossTonnageInKg, string type, string identifier, int effectInKw)
        {
            MaxSpeedInKnop = maxSpeedInKnop;
            GrossTonnageInKg = grossTonnageInKg;
            Type = type;
            Identifier = identifier;
            EffectInKw = effectInKw;
        }
    }
}
