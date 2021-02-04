using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Smirnov.StrategyGame_1_.Units
{
    abstract class Unit
    {

        public string Name { get; set; }
        public int Health { get; set; }
        public Unit(string name, int health)
        {
            Name = name;
            Health = health;
        }
    }
}
