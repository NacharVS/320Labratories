using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Shooter : Military, IMakeDamage//стрелок
    {
        public override int Armor { get; set; }
        public override int Health { get; set; }
        public override int Force { get; set; }
        public int NumberOfArrow { get; set; }

        public int FiringRange { get; set; }

        public Shooter(int armor, int health,int force, int numberOfArrow, int firingRange)
        {
            this.Health = health;
            this.Armor = armor;
            this.NumberOfArrow = numberOfArrow;
            this.FiringRange = firingRange;
            this.Force = force;
        }

        public int MakeDamage()
        {
            throw new NotImplementedException();
        }

    }
}
