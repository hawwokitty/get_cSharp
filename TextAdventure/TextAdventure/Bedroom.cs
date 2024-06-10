namespace TextAdventure
{
    internal class Bedroom : Room
    {
        public override void SetTasks()
        {
            _listOfTasks = new List<Task>()
            { 
                new Task("Wake Up in Bed", "Check phone", "You check your messages but feel overwhelmed by the number of unread texts", false, "check phone", "look at phone", "mobile", "phone", "get phone"),
                new Task("Wake Up in Bed", "Get up", "You try to get up, but it feels like there's an invisible force keeping you down", false, "get up", "get out of bed", "stand up", "sit up"),
                new Task("Wake Up in Bed", "Go back to sleep", "You pull the covers over your head, hoping to escape your thoughts for a little while longer", true, "go back to sleep", "sleep", "cover head", "hide under covers", "sleep more"),
                new Task("Move rooms", "Go to kitchen", "You manage to drag yourself to the kitchen", true, "exit bedroom", "walk out of room", "go to the kitchen", "go eat", "kitchen"),
                new Task("Move rooms", "Go to bathroom", "You manage to drag yourself to the bathroom", true, "exit bedroom", "walk out of room", "go to the bathroom", "use bathroom", "bathroom"),

            };
        }
    }
}