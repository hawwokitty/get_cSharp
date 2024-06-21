namespace FlappyBird
{
    internal class Bird
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public bool IsAlive { get; set; }

        public Bird()
        {
            PosX = 10;
            PosY = 10;
            IsAlive = true;
        }
        public void Move(int x, int y)
        {
            PosX += x;
            PosY += y;
        }
    }
}
