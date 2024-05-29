namespace Sims
{
    internal class FurnitureWithActions(string room, string furniture, params string[] action)
    {
        public string Room { get; private set; } = room;
        public string Furniture { get; private set; } = furniture;
        public string[] Actions { get; private set; } = action;
        public FurnitureWithActions(string room, string furniture) : this(room, furniture, "None", "None")
        {
        }
    }
}