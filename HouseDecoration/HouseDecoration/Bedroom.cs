namespace HouseDecoration
{
    internal class Bedroom : Room
    {
        public Bedroom()
        {
            Name = "Bedroom";
            WallColor = "White";
            ListOfPossibleFurniture = new List<string>()
            {
                "Bed",
                "Nightstand",
                "Dresser",
                "Wardrobe",
                "Lamp",
                "Plant"
            };
            ListOfFurniture = new List<string>();
        }
    }
}
