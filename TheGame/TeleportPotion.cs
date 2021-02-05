using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    class TeleportPotion : Consumable
    {
        public TeleportPotion() : base("Teleport Potion")
        {

        }

        public override void GiveEffect(Player player)
        {

            player.X = 0;
            player.Y = 0;
            player.Health -= 10;
        }
    }
}
