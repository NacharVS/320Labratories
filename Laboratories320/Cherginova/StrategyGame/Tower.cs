using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Tower : Building, IDestroyBuilding
    {
        public override int Strength { get; set; }
        public override int NumberOfPeople { get; set; }

        public int NumberOfWeapon { get; set; }

        public Tower(int strength, int numberOfPeople, int numberOfWeapon)
        {
            this.Strength = strength;
            this.NumberOfPeople = numberOfPeople;
            this.NumberOfWeapon = numberOfWeapon;
        }

        public int DestroyBuilding()
        {
            throw new NotImplementedException();
        }
    }
}
