using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    class YourDarkestDisgrace : Monster
    {
        public YourDarkestDisgrace() : base("Your darkest Disgrace", 100, 15)
        {

        }

        public override void Battle(Character attacker, Character defender)
        {
            attacker.Health += defender.Strength;
            attacker.Strength -= 10;
        }
    }
}
