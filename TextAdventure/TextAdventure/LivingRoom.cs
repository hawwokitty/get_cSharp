namespace TextAdventure
{
    internal class LivingRoom : Room
    {
        public override void SetTasks()
        {
            _listOfTasks = new List<Task>()
            {
                new Task("In the Living Room", "Try to do some work", "You sit at your desk, but your mind feels foggy, and you can't concentrate", false, "do work", "work", "desk", "focus"),
                new Task("In the Living Room", "Watch TV", "You turn on the TV, hoping for a distraction, but nothing holds your interest", false, "watch TV", "TV", "television", "distraction"),
                new Task("In the Living Room", "Take a walk outside", "Stepping outside feels intimidating, but the fresh air provides a small relief", true, "walk outside", "go outside", "fresh air", "walk")
            };
        }
    }
}