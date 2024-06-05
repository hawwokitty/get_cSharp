namespace Abaxrekruttering
{
    internal interface ITransportation
    {
        public string Type { get; set; }
        public string Identifier { get; set; }
        public int EffectInKw { get; set; }

        public void Operate();

        public void PrintInfo();
    }
}
