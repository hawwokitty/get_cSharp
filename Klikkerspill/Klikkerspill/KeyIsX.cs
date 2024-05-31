namespace Klikkerspill
{
    internal class KeyIsX : ICommand
    {
        public char Key => 'x';

        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
