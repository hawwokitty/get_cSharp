namespace Snake
{
    internal class Snake
    {
        public bool IsAlive { get; set; }
        //public int HeadPosX { get; private set; }
        //public int HeadPosY { get; private set; }
        public int Speed { get; private set; }
        //public int SnakeLength { get; private set; }
        public List<SnakeBodyParts> SnakeBody = new List<SnakeBodyParts>();
        Random random = new Random();

        public Snake()
        {
            int x = random.Next(1, Console.WindowWidth - 1);
            int y = random.Next(1, Console.WindowHeight - 1);
            SnakeBody.Add(new SnakeBodyParts(x, y));
            //SnakeLength = SnakeBody.Count;
            IsAlive = true;
            Speed = 100;
        }

        public void Move(int x, int y)
        {
            //HeadPosX += x;
            //HeadPosY += y;
            SnakeBody[0].BodyPosX += x;
            SnakeBody[0].BodyPosY += y;
        }

        public void MoveBody(int x, int y)
        {
            for (int i = 1; i < SnakeBody.Count; i++)
            {
                SnakeBody[i].SetPos(SnakeBody[i - 1].BodyPosX - x, SnakeBody[i - 1].BodyPosY - y);
            }
        }

        public void Grow((int X, int Y) previousMoveDone)
        {
            //if (SnakeLength == 0)
            //{
            //    SnakeBody.Add(new SnakeBodyParts(HeadPosX - previousMoveDone.X, HeadPosY - previousMoveDone.Y));
            //}
            //else
            //{
            SnakeBody.Add(new SnakeBodyParts(SnakeBody[SnakeBody.Count - 1].BodyPosX - previousMoveDone.X, SnakeBody[SnakeBody.Count - 1].BodyPosY - previousMoveDone.Y));
            //}

            //SnakeLength++;
            Speed--;
        }
    }
}
