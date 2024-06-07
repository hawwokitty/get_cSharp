namespace TextAdventure
{
    internal class Bedroom : Room
    {
        public Bedroom() : base("Bedroom")
        {
        }

        protected override void SetTasks()
        {
            _listOfTasks = new List<Task>()
            {
                new Task("Wake Up in Bed", "Check phone", "You scroll aimlessly through TikTok until your head hurts, and you have to put the phone down", "check phone", "look at phone", "mobile", "phone", "social media", "get phone"),
                new Task("Wake Up in Bed", "Check phone", "You check your messages but feel overwhelmed by the number of unread texts", "check phone", "look at phone", "mobile", "phone", "get phone"),
                new Task("Wake Up in Bed", "Get up", "You try to get up, but it feels like there's an invisible force keeping you down", "get up", "get out of bed", "stand up", "sit up"),
                new Task("Wake Up in Bed", "Go back to sleep", "You pull the covers over your head, hoping to escape your thoughts for a little while longer", "go back to sleep", "sleep", "cover head", "hide under covers")
            };
        }
    }
}