using System;

namespace TheGame
{
    internal class ConsoleGame
    {
        Player player;
        Room[,] world;
        Random random = new Random();
        public void Play()
        {
            //GameIntro();
            CreatePlayer();
            //WelcomePlayer();
            CreateWorld();

            do
            {
                Console.Clear();

                DisplayWorld();
                DisplayStats();
                AskForMovement();
                CheckForEvent();

            } while (player.Health > 0);

            GameOver();
        }

        private void GameIntro()
        {
            TextUtils.Animate("This is Dungeons Of Doom...".ToUpper(), 100);
            TextUtils.Animate("...or is it...?", 300);
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
                    else if (randomPercentage < 18)
                        world[x, y].Item = new LieDetector();
                    else if (randomPercentage < 24)
                        world[x, y].Item = new ThunderHoney();
                    else if (randomPercentage < 30)
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
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("P");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (room.Monster != null)
                        Console.Write(room.Monster.Name[0]);
                    else if (room.Item != null)
                        Console.Write(room.Item.Name[0]);
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        private void DisplayStats()
        {
            Console.WriteLine("\n_-_-_-PLAYER STATS-_-_-_\n");
            Console.WriteLine($"Strength: {player.Strength}");
            Console.WriteLine($"Health: {player.Health}");
        }

        private void AskForMovement()
        {
            int newX = player.X;
            int newY = player.Y;
            bool isValidKey = true;

            ConsoleKey input = Console.ReadKey(true).Key;

            // Add condition so player cannot move out from world
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    newY--;
                    break;
                case ConsoleKey.DownArrow:
                    newY++;
                    break;
                case ConsoleKey.LeftArrow:
                    newX--;
                    break;
                case ConsoleKey.RightArrow:
                    newX++;
                    break;
                default:
                    isValidKey = false;
                    break;
            }

            if (isValidKey &&
                newX < world.GetLength(0) && newX >= 0 &&
                newY < world.GetLength(1) && newY >= 0)
            {
                player.X = newX;
                player.Y = newY;
            }
        }

        private void CheckForEvent()
        {
            if (world[player.X, player.Y].Item != null)
            {
                world[player.X, player.Y].Item.GiveEffect(player);
                
            }
        }

        private void GameOver()
        {
            Console.WriteLine("Game over...");
        }

    }
}