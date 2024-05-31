namespace Lagerstyringssystem
{
    internal class Klær : IProdukt
    {
        private string Størrelse { get; set; }
        public string Navn { get; set; }
        public double Pris { get; set; }

        public Klær(string navn, int pris, string størrelse)
        {
            Navn = navn;
            Pris = pris;
            Størrelse = størrelse;
        }
        public void SkrivUtInfo()
        {
            
        }
    }
}
