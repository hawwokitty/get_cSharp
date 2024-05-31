namespace Klikkerspill
{
    internal class KeyIsK : ICommand
    {
        public char Key => 'k';
        private int _cost = 10;
        public void Run()
        {
            if (ClickerGame.Points >= _cost)
            {
                ClickerGame.Points -= 10;
                ClickerGame.AddPointsPerClick();
            }
        }
    }
}
