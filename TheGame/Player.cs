namespace TheGame
{
    internal class Player : Character
    {
        public Player() : base("Madame E Petit", 20, 10)
        {
            X = 0;
            Y = 0;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override void Battle(Character attacker, Character defender)
        {
            defender.Health -= attacker.Strength;
        }
    }
}