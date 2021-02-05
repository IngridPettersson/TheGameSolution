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

        public override void GiveEffect(Player player)
        {
            player.Strength -= player.Strength / 4;
        }
    }
}
