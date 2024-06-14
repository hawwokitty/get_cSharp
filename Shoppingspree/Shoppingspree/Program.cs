using Shoppingspree;

int salePercent = 20;
ClothingItem shirt = new ClothingItem("Men`s T-shirt", 50, 200, "Large", "Blue");
var salePrice = shirt.CalculateSalePrice(salePercent);
Console.WriteLine($"There is a {salePercent}% sale! The sale price of the shirt is: {salePrice}, original price is {shirt.Price}");
ElectronicsItem phone = new ElectronicsItem("Iphone X", 25, 3400, "1 year", 1);
salePrice = phone.CalculateSalePrice(salePercent);
Console.WriteLine($"The sale price of the phone is: {salePrice}");