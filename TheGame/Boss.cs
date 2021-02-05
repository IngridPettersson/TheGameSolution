using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    class Boss : Character
    {
        public Boss(int x, int y) : base("DUALITY", 100, 500)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override void Battle(Character attacker, Character defender)
        {
        }
    }
}
