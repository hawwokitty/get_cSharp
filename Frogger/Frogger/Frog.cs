namespace Frogger
{
    internal class Frog
    {
        public int Lives { get; private set; }
        public int PosX { get; private set; }
        public int PosY { get; private set; }
        public Frog()
        {
            Lives = 3;
            PosX = 20;
            PosY = 6;
        }

        public void Move(int x, int y) { PosX += x; PosY += y; }

        public void LoseALife()
        {
            Lives--;
        }

        public void SetPos(int x, int y)
        {
            PosX = x; PosY = y;
        }
    }
}
