using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Shooter : Unit
    {
        public int RangeOfFire { get; set; }
        public int RateOfFire { get; set; }

        public Shooter(string name, int level, int health, int race, int damage, int speed, int rangeOfFire, int rateOfFire) : base(name, level, health, race, damage, speed)
        {
            this.RangeOfFire = rangeOfFire;
            this.RateOfFire = rateOfFire;
        }
        public void GoIntoMelee()
        {
            Console.WriteLine("I'm going into melee");
        }

        public void SettingUpWeapons()
        {
            Console.WriteLine("Charge it! Aim! Fire!");
        }


    }
}
