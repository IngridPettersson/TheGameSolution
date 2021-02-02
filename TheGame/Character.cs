using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    abstract class Character
    {
        public int Health { get; set; }

        public Character(int health)
        {
            Health = health;
        }
    }
}
