namespace Frogger
{
    internal class Car
    {
        public int Length { get; private set; }
        public int Speed { get; private set; }
        public int PosX { get; private set; }
        public int PosY { get; private set; }
        private Random _random = new Random();

        public Car(int posY)
        {
            int randomPos = _random.Next(0, 41);
            PosX = randomPos;
            PosY = posY;
        }

        public void Move(int x)
        {
            if (PosX == 0)
            {
                PosX = 40;
            }
            else
            {
                PosX -= x;
            }
        }
    }
}
