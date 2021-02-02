namespace TheGame
{
    internal class Player : Character
    {
        public Player() : base(100)
        {
            X = 0;
            Y = 0;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}