namespace Snake
{
    internal class SnakeBodyParts
    {
        public int BodyPosX { get; set; }
        public int BodyPosY { get; set; }

        public SnakeBodyParts(int bodyPosX, int bodyPosY)
        {
            BodyPosX = bodyPosX;
            BodyPosY = bodyPosY;
        }


        public void SetPos(int x, int y)
        {
            BodyPosX = x;
            BodyPosY = y;
        }
    }
}
