using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }


        public Character(string name, int health, int strength)
        {
            Name = name;
            Health = health;
            Strength = strength;
        }

        public abstract void Battle(Character attacker, Character defender);
    }
}
