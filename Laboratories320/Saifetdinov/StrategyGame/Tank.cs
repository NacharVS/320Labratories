using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Tank : Unit
    {
        public int Protection { get; set; }

        public Tank(string name, int level, int health, int race, int damage, int speed, int protection) : base(name, level, health, race, damage, speed)
        {
            this.Protection = protection;
        }
        public void ToProtect()
        {
            Console.WriteLine("To raise their shields");
        }
    
    }
}
