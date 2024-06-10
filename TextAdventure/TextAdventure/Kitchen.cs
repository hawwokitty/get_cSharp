namespace TextAdventure
{
    internal class Kitchen : Room
    {
        public override void SetTasks()
        {
            _listOfTasks = new List<Task>()
            {
                new Task("In the Kitchen", "Open the fridge", "You open the fridge and feel overwhelmed by the thought of making breakfast", false, "open fridge", "look in fridge", "fridge", "breakfast"),
                new Task("In the Kitchen", "Grab a snack", "You grab a quick snack, something easy, and try to muster the energy for the next step", true, "grab snack", "eat snack", "snack", "food"),
                new Task("In the Kitchen", "Sit at the table", "You sit at the table, staring blankly, trying to gather the strength to move", true, "sit at table", "sit", "table", "rest")
            };
        }
    }
}