using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Farm : Building, IDestroyBuilding
    {
        public override int Strength { get; set; }
        public override int NumberOfPeople { get; set; }

        public int NumberOfObject { get; set; }
        public Farm(int strength, int numberOfPeople, int numberOfObject)
        {
            this.Strength = strength;
            this.NumberOfPeople = numberOfPeople;
            this.NumberOfObject = numberOfObject;
        }

        public int DestroyBuilding()
        {
            throw new NotImplementedException();
        }
    }
}
