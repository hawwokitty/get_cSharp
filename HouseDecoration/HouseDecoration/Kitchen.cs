namespace HouseDecoration
{
    internal class Kitchen : Room
    {
        public Kitchen()
        {
            Name = "Kitchen";
            WallColor = "White";
            ListOfPossibleFurniture = new List<string>()
            {
                "Kitchen Cabinet",
                "Refrigerator",
                "Freezer",
                "Microwave",
                "Stove",
                "Oven",
                "Kitchen counter",
            };
            ListOfFurniture = new List<string>();
        }
    }
}
