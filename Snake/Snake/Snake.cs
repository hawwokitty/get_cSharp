namespace Snake
{
    internal class Snake
    {
        public bool IsAlive { get; set; }
        public int Speed { get; private set; }
        public List<SnakeBodyParts> SnakeBody = new List<SnakeBodyParts>();
        Random random = new Random();

        public Snake()
        {
            int x = random.Next(1, Console.WindowWidth - 1);
            int y = random.Next(1, Console.WindowHeight - 1);
            SnakeBody.Add(new SnakeBodyParts(x, y));
            SnakeBody.Add(new SnakeBodyParts(x, y));
            IsAlive = true;
            Speed = 100;
        }

        public void Move(int x, int y)
        {
            SnakeBody[0].BodyPosX += x;
            SnakeBody[0].BodyPosY += y;
        }

        public void MoveBody()
        {
            if (SnakeBody.Count > 1)
            {
                for (int i = SnakeBody.Count - 1; i > 0; i--)
                {
                    SnakeBody[i].SetPos(SnakeBody[i - 1].BodyPosX, SnakeBody[i - 1].BodyPosY);
                }

            }
        }

        public void Grow((int X, int Y) previousMoveDone)
        {
            var x = SnakeBody[SnakeBody.Count - 1].BodyPosX - previousMoveDone.X;
            var y = SnakeBody[SnakeBody.Count - 1].BodyPosY - previousMoveDone.Y;
            SnakeBody.Add(new SnakeBodyParts(x, y));
            Speed--;
        }
    }
}