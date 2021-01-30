using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Barrack : Building, IDestroyBuilding, IRestoreHealth // kazarma
    {
        public override int Strength { get; set; }
        public override int NumberOfPeople { get; set; }

        public int NumberOfSeats { get; set; }
        public Barrack(int strength, int numberOfPeople, int numberOfSeats) 
        {
            this.Strength = strength;
            this.NumberOfPeople = numberOfPeople;
            this.NumberOfSeats = numberOfSeats;
        }

        public int DestroyBuilding()
        {
            throw new NotImplementedException();
        }

        public int RestoreHealth()
        {
            throw new NotImplementedException();
        }
    }
}
