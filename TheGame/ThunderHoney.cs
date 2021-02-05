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

        public override string GiveEffect(Player player)
        {
            int strengtGained = player.Strength / 5;
            int healthLost = player.Health / 5;
            player.Strength += strengtGained;
            player.Health -= healthLost;

            return $"You collected item: {Name}\nEffect: -{healthLost} health points\t +{strengtGained} in strength";
        }
    }
}
