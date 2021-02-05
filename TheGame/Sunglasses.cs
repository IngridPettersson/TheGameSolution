using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    class Sunglasses : Equipment
    {
        public Sunglasses() : base("Sunglasses")
        {

        }

        public override string GiveEffect(Player player)
        {
            int healthLost = 15;
            int strengthGained = player.Strength / 4;
            player.Health -= healthLost;
            player.Strength += strengthGained;

            return $"Collected item: {Name}\nEffect: -{healthLost} health points\n\t+{strengthGained} in strength";

        }
    }
}
