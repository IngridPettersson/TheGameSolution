namespace TheGame
{
    internal class Player : Character
    {
        public Player() : base("Madame E Petit", 100, 10)
        {
            X = 0;
            Y = 0;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}