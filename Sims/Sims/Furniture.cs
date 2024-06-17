using System;

namespace Sims
{
    internal class Furniture
    {
        private string? Room { get; set; } 
        private string? FurnitureName { get; set; }
        private string[]? Actions { get; set; }

        private List<Furniture>? _furniture;
        public Furniture(string room, string furniture, params string[] action)
        {
            Room = room;
            FurnitureName = furniture;
            Actions = action;
        }
        public Furniture()
        {
            
        }


        public void InitializeFurniture()
        {
            _furniture = new List<Furniture>
            {
                new ("Living Room", "Sofa", "Sit", "Nap"),
                new ("Living Room", "Coffee Table"),
                new ("Living Room", "TV Stand"),
                new ("Living Room", "Recliner", "Sit", "Recline"),
                new ("Living Room", "Ottoman", "Sit"),
                new ("Living Room", "Armchair", "Sit"),
                new ("Living Room", "TV", "Watch"),
                new ("Living Room", "Bookshelf", "Admire"),
                new ("Living Room", "Carpet"),
                new ("Living Room", "Lamp", "Illuminate"),
                new ("Living Room", "Plant", "Water"),
                new ("Living Room", "Fireplace", "Get cozy", "Warm up"),

                new ("Dining Room", "Dining Table"),
                new ("Dining Room","Dining Chairs", "Sit"),
                new ("Dining Room","Lamp", "Illuminate"),

                new ("Bedroom", "Bed", "Sleep", "Relax", "Woohoo"),
                new ("Bedroom","Nightstand", "Store Items"),
                new ("Bedroom","Dresser", "Store Clothes", "Get clothes"),
                new ("Bedroom","Wardrobe", "Store Clothes", "Get clothes"),
                new ("Bedroom","Lamp", "Illuminate"),
                new ("Bedroom","Plant", "Water"),

                new ("Office", "Desk", "Work", "Study"),
                new ("Office","Office Chair", "Sit"),
                new ("Office","Bookshelf", "Admire"),
                new ("Office","Computer", "Work", "Game"),
                new ("Office","Fan", "Cool down"),

                new ("Kitchen","Kitchen Cabinet", "Store Items", "Get items"),
                new ("Kitchen","Refrigerator", "Place food", "Get food"),
                new ("Kitchen","Freezer", "Freeze Food"),
                new ("Kitchen","Microwave", "Heat food"),
                new ("Kitchen","Stove", "Cook Food"),
                new ("Kitchen","Oven", "Bake Food"),
                new ("Kitchen","Kitchen counter", "Prepare Food"),

                new ("Bathroom","Toilet", "Use"),
                new ("Bathroom","Shower", "Shower"),
                new ("Bathroom","Bathtub", "Bathe"),
                new ("Bathroom","Sink", "Wash Hands", "Wash face"),
                new ("Bathroom","Closet", "Store Items"),
                new ("Bathroom","Cupboard", "Store Items"),
                new ("Bathroom","Mirror", "Reflect", "Practice talking to yourself"),
            };
        }

        public void ShowFurniture(string room)
        {
            List<Furniture> furnitureList = _furniture.Where(f => f.Room == room).ToList();
            for (int i = 0; i < furnitureList.Count; i++)
            {
                $"{i + 1}. {furnitureList[i].FurnitureName}".PrintToConsole();
            }
        }

    }
}
