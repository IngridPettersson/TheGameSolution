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

        public override string GiveEffect(Player player)
        {
            int strengthGained = player.Strength / 3;
            player.Strength += strengthGained;

            return $"You collected item: {Name}\nEffect: +{strengthGained} in strength";

        }
    }
}
