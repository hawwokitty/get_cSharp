using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Shoppingspree
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        private string _size { get; set; }
        private string _color { get; set; }

        public ClothingItem(string name, int amount, double price, string size, string color)
        {
            Name = name;
            Amount = amount;
            Price = price;
            _size = size;
            _color = color;
        }

        public double CalculateSalePrice(int salePercent)
        {
            return Price - (Price * ((double)salePercent / 100));
        }

    }
}
