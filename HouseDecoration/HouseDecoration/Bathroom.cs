namespace HouseDecoration
{
    internal class Bathroom : Room
    {
        public Bathroom()
        {
            Name = "Bathroom";
            WallColor = "White";
            ListOfPossibleFurniture = new List<string>()
            {
                "Toilet",
                "Shower",
                "Bathtub",
                "Sink",
                "Closet",
                "Cupboard",
                "Mirror",
                "Plant",
            };
            ListOfFurniture = new List<string>();
        }
    }
}
