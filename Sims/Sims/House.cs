namespace Sims
{
    internal class House : Room
    {
        public House(string room, params string[] furniture) : base(room, furniture)
        {
        }

        public House() : base()
        {
            
        }

        public void MakeNewHouse()
        {
            "A base house has these rooms:".PrintToConsole();
            for (int i = 0; i < rooms.Count; i++)
            {
                $"{i+1}. {rooms[i]}".PrintToConsole();
            }
        }
    }
}
