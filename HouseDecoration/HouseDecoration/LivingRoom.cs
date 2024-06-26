namespace HouseDecoration
{
    internal class LivingRoom : Room
    {
        public LivingRoom()
        {
            Name = "Living Room";
            WallColor = "White";
            ListOfPossibleFurniture = new List<string>()
            {
                "Sofa",
                "Coffee Table",
                "TV Stand",
                "Recliner",
                "Ottoman",
                "Armchair",
                "TV",
                "Bookshelf",
                "Carpet",
                "Lamp",
                "Plant",
                "Fireplace",
            };
            ListOfFurniture = new List<string>();
        }
    }
}
