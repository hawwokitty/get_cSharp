namespace Klikkerspill
{
    internal class KeyIsSpace : ICommand
    {
        public char Key => ' ';
        public void Run()
        {
            ClickerGame.Click();
        }
    }
}
