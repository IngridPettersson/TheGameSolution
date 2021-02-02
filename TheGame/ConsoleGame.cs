using System;

namespace TheGame
{
    internal class ConsoleGame
    {
        Player player;
        Room[,] world;
        Room room;
        Random random = new Random();
        public ConsoleGame()
        {
            CreatePlayer();
            CreateWorld();

            do
            {
                DisplayWorld();
                AskForMovement();

            } while (player.Health > 0);
        }

        private void CreatePlayer()
        {
            player = new Player();

        }

        private void CreateWorld()
        {
            world = new Room[20, 5];

            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new Room();

                    int randomPercentage = random.Next(0, 100);

                    if (randomPercentage < 5)
                        world[x, y].Monster = new YourRegret();
                    else if (randomPercentage < 10)
                        world[x, y].Monster = new YourDarkestDisgrace();
                    else if (randomPercentage < 13)
                        world[x, y].Item = new Sunglasses();
                    else if (randomPercentage < 16)
                        world[x, y].Item = new LieDetector();
                    else if (randomPercentage < 21)
                        world[x, y].Item = new ThunderHoney();
                    else if (randomPercentage < 25)
                        world[x, y].Item = new TeleportPotion();

                }
            }
        }

        private void DisplayWorld()
        {
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    Room room = world[x, y];

                    if (x == player.X && y == player.Y)
                        Console.Write("P");
                    else if (room.Monster != null)
                        Console.Write("M");
                    else if (room.Item != null)
                        Console.Write("I");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        private void AskForMovement()
        {
            throw new NotImplementedException();
        }

    }
}