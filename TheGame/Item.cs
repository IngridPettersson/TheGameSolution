using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    abstract class Item
    {
        public string Name { get; set; }
        public Item(string name)
        {
            Name = name;
        }
    }
}
