namespace Lagerstyringssystem
{
    internal class Matvare : IProdukt
    {
        private DateOnly Utløpsdato { get; set; }
        public string Navn { get; set; }
        public double Pris { get; set; }

        public Matvare(string navn, int pris, DateOnly dato)
        {
            Navn = navn;
            Pris = pris;
            Utløpsdato = dato;
        }
        public void SkrivUtInfo()
        {
            
        }
    }
}
