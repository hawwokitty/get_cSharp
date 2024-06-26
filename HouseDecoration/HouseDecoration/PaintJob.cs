namespace HouseDecoration
{
    internal class PaintJob : ICommand
    {
        public string Label => "Paint job";
        public int Option => 2;
    }
}
