namespace Abaxrekruttering
{
    internal class Car : ITransportation
    {
        public int MaxSpeedInKmPerH { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public string Identifier { get; set; }
        public int EffectInKw { get; set; }
        public void Operate()
        {
            Console.WriteLine($"Bil {Identifier} kjører");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Kjennetegn: {Identifier}");
            Console.WriteLine($"Maksfart: {MaxSpeedInKmPerH} km/t");
            Console.WriteLine($"Effekt: {EffectInKw} kw");
            Console.WriteLine($"Farge: {Color} kw");
            Console.WriteLine($"Type: {Type}");
        }

        public Car(string identifier, int maxSpeedInKmPerH, string color, string type, int effectInKw)
        {
            MaxSpeedInKmPerH = maxSpeedInKmPerH;
            Color = color;
            Type = type;
            Identifier = identifier;
            EffectInKw = effectInKw;
        }

        
    }
}
