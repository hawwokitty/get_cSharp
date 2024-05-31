namespace Lagerstyringssystem
{
    internal class Lager
    {
        private List<IProdukt> _produktListe = new List<IProdukt>();

        public void LeggTilProdukt(IProdukt produkt)
        {
            _produktListe.Add(produkt);
        }

        public void FjernProdukt(IProdukt produkt)
        {
            _produktListe.Remove(produkt);
        }

        public void ListOppAlleProdukter()
        {
            foreach (var produkt in _produktListe)
            {
                Console.WriteLine($"- {produkt.Navn}");
            }
        }
    }
}
