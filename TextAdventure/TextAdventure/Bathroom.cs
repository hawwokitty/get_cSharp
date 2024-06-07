namespace TextAdventure
{
    internal class Bathroom : Room
    {
        public Bathroom() : base("Bathroom")
        {
        }

        protected override void SetTasks()
        {
            _listOfTasks = new List<Task>()
            {
                new Task("In the Bathroom", "Stand in front of the mirror", "You stand in front of the mirror, struggling to recognize the person staring back at you", "stand in front of mirror", "mirror", "look in mirror", "reflection"),
                new Task("In the Bathroom", "Brush your teeth", "Brushing your teeth feels like an enormous task, but you manage to do it", "brush teeth", "teeth", "brush", "hygiene"),
                new Task("In the Bathroom", "Take a shower", "Taking a shower seems overwhelming, but you manage to turn on the water and step in", "take shower", "shower", "clean", "water")
            };
        }
    }
}