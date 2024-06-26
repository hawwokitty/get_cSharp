namespace HouseDecoration
{
    internal interface ICommand
    {
        public string Label { get; }
        public int Option { get; }
    }
}
