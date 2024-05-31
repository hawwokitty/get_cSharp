namespace Sims
{
    internal class Room
    {
        private string RoomName { get; set; }
        private Furniture[] FurnitureArray { get; set; }


        public List<string> rooms = new List<string>
        {
            "Living Room",
            "Kitchen",
            "Dining Room",
            "Bedroom",
            "Bathroom",
            "Office",
        };

        public Room(string room, params string[] furniture)
        {
            RoomName = room;
            
        }
    }
}
