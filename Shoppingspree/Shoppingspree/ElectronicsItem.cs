using System.Runtime.CompilerServices;

namespace Shoppingspree
{
    internal class ElectronicsItem : InventoryItem, ISellable
    {
        private string _insuranceInfo { get; set; }
        private int _volt { get; set; }

        public ElectronicsItem(string name, int amount, double price, string insuranceInfo, int volt)
        {
            Name = name;
            Amount = amount;
            Price = price;
            _insuranceInfo = insuranceInfo;
            _volt = volt;
        }
        public double CalculateSalePrice(int salePercent)
        {
            return Price - (Price * ((double)salePercent / 100));
        }
    }
}
