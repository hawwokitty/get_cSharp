namespace HouseDecoration
{
    internal class Room
    {
        public string Name { get; protected set; }
        protected string WallColor { get; set; }
        private List<string> ListOfColors = new List<string>()
        {
            "White",
            "Black",
            "Gray",
            "Blue",
            "Green",
            "Yellow",
            "Red",
            "Purple",
            "Orange",
            "Brown",
            "Beige",
            "Pink",
            "Teal",
            "Navy",
            "Maroon",
            "Gold",
            "Silver",
            "Coral",
            "Lavender",
            "Olive"
        };
        protected List<string> ListOfConstructingItems = new List<string>()
        {
            "Door",
            "Window",
            "Tiles",
        };
        protected List<string> ListOfPossibleFurniture { get; set; }
        protected List<string> ListOfFurniture { get; set; }
        public Room()
        {
        }

        public void Decorate()
        {
            while (true)
            {
                PickAndAddFurniture();
                "Would you like to add more?".PrintToConsole();
                "1. Yes".PrintToConsole();
                "2. No".PrintToConsole();
                switch ("Please enter a number from the menu above:".RequestInt(2))
                {
                    case 1: break;
                    case 2: return;
                }
            }

        }

        private void PickAndAddFurniture()
        {
            "Here is a list of the possible furniture you may place:".PrintToConsole();
            for (var i = 0; i < ListOfPossibleFurniture.Count; i++)
            {
                $"{i + 1}. {ListOfPossibleFurniture[i]}".PrintToConsole();
            }
            int userInput = "Please enter a number from the menu above to add that furniture:".RequestInt(ListOfPossibleFurniture.Count) - 1;
            ListOfFurniture.Add(ListOfPossibleFurniture[userInput]);
            $"You successfully added {ListOfPossibleFurniture[userInput]} to {Name}".PrintToConsole();
        }

        public void PaintJob()
        {
            while (true)
            {
                PickAndPaintWall();
                "Would you like to paint again?".PrintToConsole();
                "1. Yes".PrintToConsole();
                "2. No".PrintToConsole();
                switch ("Please enter a number from the menu above:".RequestInt(2))
                {
                    case 1: break;
                    case 2: return;
                }
            }
        }

        private void PickAndPaintWall()
        {
            "Here is a list of the possible colors you can paint the wall with:".PrintToConsole();
            for (var i = 0; i < ListOfColors.Count ; i++)
            {
                $"{i + 1}. {ListOfColors[i]}".PrintToConsole();
            }
            int userInput = "Please enter a number from the menu above to add that furniture:".RequestInt(ListOfColors.Count) - 1;
            WallColor = ListOfColors[userInput];
            $"You successfully painted the wall of {Name} {ListOfColors[userInput]}".PrintToConsole();
        }

        public void Construction()
        {

        }

        public string GetRoomState()
        {
            string ListOfFurnitureInStringForm = "";
            if (ListOfFurniture.Count > 0)
            {
                foreach (var furnature in ListOfFurniture)
                {
                    ListOfFurnitureInStringForm += $"- {furnature} \n";
                }
            }
            else
            {
                ListOfFurnitureInStringForm = "There are no furniture here yet \n";
            }

            return $"Room: {Name} \nWallpaint: {WallColor} \nFurniture: \n{ListOfFurnitureInStringForm}";
        }
    }
}
