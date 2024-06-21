using System.Xml.Linq;

namespace FlappyBird
{
    internal class Game
    {
        public List<Obstacle> ListOfObstacles { get; set; }
        public int Highscore { get; set; } = 0;
        public int Speed { get; set; } = 200;
        public void Run()
        {
            Bird bird = new Bird();
            ListOfObstacles = new List<Obstacle>
            {
                new (Console.WindowWidth - 101),
                new (Console.WindowWidth - 101),
                new (Console.WindowWidth - 81),
                new (Console.WindowWidth - 81),
                new (Console.WindowWidth - 61),
                new (Console.WindowWidth - 61),
                new (Console.WindowWidth - 41),
                new (Console.WindowWidth - 41),
                new (Console.WindowWidth - 21),
                new (Console.WindowWidth - 21),
                new (Console.WindowWidth - 1),
                new (Console.WindowWidth - 1),
        };
            Task.Run(() => HandleUserInput(bird));
            while (bird.IsAlive)
            {
                ConsoleLines.PrintMapAndBird(bird, ListOfObstacles);
                AddObstacles();
                bird.Move(0, 1);
                foreach (var obstacle in ListOfObstacles)
                {
                    obstacle.Move();
                }
                CheckForInteraction(bird);
                Thread.Sleep(Speed);
            }

            ConsoleLines.GameOver(Highscore);
        }

        private void AddObstacles()
        {
            if (ListOfObstacles[0].PosX <= 5 || ListOfObstacles[1].PosX <= 5)
            {
                ListOfObstacles.Remove(ListOfObstacles[0]);
                ListOfObstacles.Remove(ListOfObstacles[0]);
                ListOfObstacles.Add(new Obstacle(Console.WindowWidth - 1));
                ListOfObstacles.Add(new Obstacle(Console.WindowWidth - 1));
                Highscore += 1;
                Speed -= 1;
            }
        }

        private void CheckForInteraction(Bird bird)
        {
            // check if crash with obstacle
            foreach (var obstacle in ListOfObstacles)
            {
                if (bird.PosX == obstacle.PosX && 
                    (
                    bird.PosY == obstacle.PosY1 || 
                    bird.PosY == obstacle.PosY2 || 
                    bird.PosY == obstacle.PosY3 || 
                    bird.PosY == obstacle.PosY4 || 
                    bird.PosY == obstacle.PosY5
                    )
                   )
                {
                    bird.IsAlive = false;
                }
            }
            // check if crash with window
            if (bird.PosY == Console.WindowHeight - 1 || bird.PosY == 1)
            {
                bird.IsAlive = false;
            }

        }

        private async Task HandleUserInput(Bird bird)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var userKeyPress = Console.ReadKey(true);
                    switch (userKeyPress.Key)
                    {
                        case ConsoleKey.UpArrow:
                            bird.Move(0, -2);
                            break;
                        case ConsoleKey.DownArrow:
                            bird.Move(0, 2);
                            break;
                    }
                }
                await Task.Delay(10);
            }
        }
    }
}
