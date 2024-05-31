namespace Lagerstyringssystem
{
    internal class Elektronikk :IProdukt
    {
        private int GarantitidIMåneder { get; set; }
        public string Navn { get; set; }
        public double Pris { get; set; }

        public Elektronikk(string navn, int pris, int garanti)
        {
            Navn = navn;
            Pris = pris;
            GarantitidIMåneder = garanti;
        }
        public void SkrivUtInfo()
        {
            
        }
    }
}
