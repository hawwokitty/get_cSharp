namespace Klikkerspill
{
    internal class KeyIsS : ICommand
    {
        public char Key => 's';
        private int _cost = 100;

        public void Run()
        {
            if (ClickerGame.Points >= 100)
            {
                ClickerGame.Points -= 100;
                ClickerGame.IncreasePointsPerClick();
            }
        }
    }
}
