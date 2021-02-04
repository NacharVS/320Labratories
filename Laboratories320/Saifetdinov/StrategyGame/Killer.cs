using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Killer : Unit
    {
        public int TimeOfInvisibility { get; set; }

        public Killer(string name, int level, int health, int race, int damage, int speed, int timeOfInvisibility) : base(name, level, health, race, damage, speed)
        {
            this.TimeOfInvisibility = timeOfInvisibility;
        }

        public void ToKillFromAmbush()
        {
            Console.WriteLine("I see the goal, I go to the goal");
        }
    }
}
