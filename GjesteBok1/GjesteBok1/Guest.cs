namespace GjesteBok1
{
    internal class Guest
    {
        private string _fullname {  get; set; }
        private static int _partyNrSeed = 10000;
        public int PartyNr {  get; set; }
        private static List<Guest> _ListOfGuests = new ();

        public Guest(string name)
        {
            PartyNr = _partyNrSeed;
            _fullname = name;
            _ListOfGuests.Add(this);
        }


        public static void AddNewParty()
        {
            _partyNrSeed++;
        }

        public static void ShowParty()
        {
            "Here are the members in your party:".PrintToConsole();
            foreach (var person in _ListOfGuests)
            {
                if (_partyNrSeed == person.PartyNr)
                {
                    $"{person._fullname}".PrintToConsole();
                }
            }
        }
    }
}
