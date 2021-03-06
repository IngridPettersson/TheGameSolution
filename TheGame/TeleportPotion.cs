﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    class TeleportPotion : Consumable
    {
        public TeleportPotion() : base("Teleport Potion")
        {

        }

        public override string GiveEffect(Player player)
        {
            int healthLost = 10;
            player.X = 0;
            player.Y = 0;
            player.Health -= healthLost;

            return $"Collected item: {Name}\nEffect: -{healthLost} health points\n\tTeleported to 0.0";
        }
    }
}
