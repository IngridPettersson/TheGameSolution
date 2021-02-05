using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    abstract class Character
    {
        public string Name { get; set; }

        private int health;

        public int Health
        {
            get { return health; }
            set 
            {
                if (value < 0)
                    health = 0;
                else
                    health = value; 
            }
        }

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
