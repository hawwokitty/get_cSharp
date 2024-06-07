namespace TextAdventure
{
    internal class LivingRoom : Room
    {
        public LivingRoom() : base("Living Room")
        {
        }

        protected override void SetTasks()
        {
            _listOfTasks = new List<Task>()
            {
                new Task("In the Living Room", "Try to do some work", "You sit at your desk, but your mind feels foggy, and you can't concentrate", "do work", "work", "desk", "focus"),
                new Task("In the Living Room", "Watch TV", "You turn on the TV, hoping for a distraction, but nothing holds your interest", "watch TV", "TV", "television", "distraction"),
                new Task("In the Living Room", "Take a walk outside", "Stepping outside feels intimidating, but the fresh air provides a small relief", "walk outside", "go outside", "fresh air", "walk")
            };
        }
    }
}