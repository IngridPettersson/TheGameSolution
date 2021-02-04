using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    class ThunderHoney : Consumable
    {
        public ThunderHoney() : base("Thunder Honey")
        {

        }

        public override void GiveEffect(Player player)
        {
            player.Strength *= 2;
        }
    }
}
