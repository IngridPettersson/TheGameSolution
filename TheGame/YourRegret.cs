using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    class YourRegret : Monster
    {
        public YourRegret() : base("Your own regrets", 100, 3)
        {

        }

        public override void Battle(Character attacker, Character defender)
        {
            attacker.Health += defender.Strength;
            defender.Strength -= 2;
        }
    }
}
