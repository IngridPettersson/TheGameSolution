using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }
    }
}
