namespace FlappyBird
{
    internal class Obstacle
    {
        public int PosY1 { get; set; }
        public int PosY2 { get; set; }
        public int PosY3 { get; set; }
        public int PosY4 { get; set; }
        public int PosY5 { get; set; }
        public int PosX { get; set; }

        Random random = new Random();

        public Obstacle(int posX)
        {
            int YPos = random.Next(5, Console.WindowHeight-5);
            PosY1 = YPos;
            PosY2 = YPos + 1;
            PosY3 = YPos + 2;
            PosY4 = YPos + 3;
            PosY5 = YPos + 4;
            PosX = posX;
        }

        public void Move()
        {
            PosX -= 1;
        }
    }
}
