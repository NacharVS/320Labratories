using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Infantryman : Military, IMakeDamage//пехотинец
    {
        public override int Armor { get; set; }
        public override int Health { get; set; }
        public override int Force { get; set; }

        public string TypeOfWeapon { get; set; }

        public Infantryman(int armor, int health, int force, string typeOfWeapon)
        {
            this.Armor = armor;
            this.Health = health;
            this.Force = force;
            this.TypeOfWeapon = typeOfWeapon;
        }

        public int MakeDamage()
        {
            throw new NotImplementedException();
        }
    }
}
