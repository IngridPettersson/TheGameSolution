using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    abstract class Monster : Character
    {
        public Monster(string name, int health, int strength) : base(name, health, strength)
        {

        }
        
    }
}
