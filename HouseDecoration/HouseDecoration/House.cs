namespace HouseDecoration
{
    internal class House
    {
        private List<Room> _listOfRooms = new List<Room>()
        {
            new Bathroom(),
            new Bedroom(),
            new LivingRoom(),
            new Kitchen(),
        };

        private List<ICommand> _listOfOptions = new List<ICommand>()
        {
            new Decorate(),
            new PaintJob(),
            new Construction()
        };
        public void Run()
        {
            "Welcome to House Decorating!".PrintToConsole();
            while (true)
            {
                "What would you like to do?".PrintToConsole();
                "1. Look at house".PrintToConsole();
                "2. Go to specific room".PrintToConsole();
                int userInput = "Please enter a number from the menu above:".RequestInt(2);
                if (userInput == 1) LookAtHouse();
                else
                {
                    var room = PickRoom();
                    PickWhatDoInRoom(room);
                }
            }
        }

        private void LookAtHouse()
        {
            foreach (var room in _listOfRooms)
            {
                room.GetRoomState().PrintToConsole();
            }
        }

        private void PickWhatDoInRoom(Room room)
        {
            $"What would you like to do in {room.Name}?".PrintToConsole();
            foreach (var option in _listOfOptions)
            {
                $"{option.Option}. {option.Label}".PrintToConsole();
            }
            "4. Go back".PrintToConsole();
            int userInput = "Please enter a number from the menu above:".RequestInt(4);
            switch (userInput)
            {
                case 1: room.Decorate(); break;
                case 2: room.PaintJob(); break;
                case 3: room.Construction(); break;
                case 4: break;
            }
        }

        private Room PickRoom()
        {
            "Which room would you like to pick?".PrintToConsole();
            for (int i = 0; i < _listOfRooms.Count; i++)
            {
                $"{i + 1}. {_listOfRooms[i].Name}".PrintToConsole();
            }
            int userInput = "Please enter a number from the menu above:".RequestInt(_listOfRooms.Count) - 1;
            Room room = _listOfRooms[userInput];
            return room;
        }
    }
}
