namespace Klikkerspill
{
    internal interface ICommand
    {
        char Key { get; }
        void Run();
    }
}
