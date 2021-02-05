using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    class LieDetector : Equipment
    {
        public LieDetector() : base("Lie Detector")
        {

        }

        public override void GiveEffect(Player player)
        {
            player.Strength += player.Strength / 5;
        }
    }
}
