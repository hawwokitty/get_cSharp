using System.Drawing;

namespace Abaxrekruttering
{
    internal class Airplane : ITransportation
    {
        public int WingSpanInM { get; set; }
        public int StorageCapacityInTonn { get; set; }
        public int OwnWeightInTonn { get; set; }
        public string Type { get; set; }
        public string Identifier { get; set; }
        public int EffectInKw { get; set; }
        public void Operate()
        {
            Console.WriteLine($"Fly {Identifier} tar av");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Kjennetegn: {Identifier}");
            Console.WriteLine($"Vingespenn: {WingSpanInM} m");
            Console.WriteLine($"Effekt: {EffectInKw} kw");
            Console.WriteLine($"Lasteevne: {StorageCapacityInTonn} tonn");
            Console.WriteLine($"Egenvekt: {OwnWeightInTonn} tonn");
            Console.WriteLine($"Type: {Type}");
        }

        public Airplane(int wingSpanInM, int storageCapacityInTonn, int ownWeightInTonn, string type, string identifier, int effectInKw)
        {
            WingSpanInM = wingSpanInM;
            StorageCapacityInTonn = storageCapacityInTonn;
            OwnWeightInTonn = ownWeightInTonn;
            Type = type;
            Identifier = identifier;
            EffectInKw = effectInKw;
        }
    }
}
