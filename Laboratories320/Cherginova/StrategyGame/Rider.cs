using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Rider : Military, IMakeDamage //наездник
    {
        public override int Armor { get; set; }
        public override int Health { get; set; }
        public override int Force { get; set; }
        public int UsedAnimalArmor { get; set; }
        public int UsedAnimalHealth { get; set; }
        public double AnimalSpeed { get; set; }

        public string TypeOfWeapon { get; set; }

        public Rider(int armor, int health, int force, string typeOfWeapon, int usedAnimalArmor, int usedAnimalHealth, double animalSpeed)
        {
            this.Armor = armor;
            this.Health = health;
            this.UsedAnimalArmor = usedAnimalArmor;
            this.UsedAnimalHealth = usedAnimalHealth;
            this.AnimalSpeed = animalSpeed;
            this.TypeOfWeapon = typeOfWeapon;
            this.Force = force;
        }

        public int MakeDamage()
        {
            throw new NotImplementedException();
        }
    }
}
