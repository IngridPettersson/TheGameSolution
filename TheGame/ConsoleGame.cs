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
            GameIntro();
            CreatePlayer();
            //WelcomePlayer();
            CreateWorld();

            do
            {
                Console.Clear();

                DisplayWorld();
                AskForMovement();

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

        private void AskForMovement()
        {
            int newY;
            int newX;
            
            ConsoleKey input = Console.ReadKey(true).Key;

            // Add condition so player cannot move out from world
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    player.Y--;
                    break;
                case ConsoleKey.DownArrow:
                    player.Y++;
                    break;
                case ConsoleKey.LeftArrow:
                    player.X--;
                    break;
                case ConsoleKey.RightArrow:
                    player.X++;
                    break;
                default:
                    break;
            }
            newY = player.Y;
            newX = player.X;
        }

        private void GameOver()
        {
        }

    }
}