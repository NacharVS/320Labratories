using Laboratories320.Hamatullin._1praktik.Interface;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Archer : WarUnit, IRechargable
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        public int Ammunition { get; set; } = 50;
        public int Range { get; } = 10;
        public int Damage { get; set; }

        public Archer(string Name, int Hp, int Speed, int Armor, int Damage) : base(Name, Hp, Speed, Armor)
        {
            this.Damage = Damage;
        }

        public void Shoot(Unit unit)
        {
            Ammunition -= 1;
            if (unit is WarUnit)
            {
                WarUnit warUnit = unit as WarUnit;
                int DamageArmor = Damage - (warUnit.Armor / 10);
                if (warUnit.Hp < DamageArmor)
                {
                    Destruction(warUnit);
                }
                else
                {
                    unit.Hp -= DamageArmor;
                }
            }
            else
            {
                if (unit.Hp < Damage)
                {
                    Destruction(unit);
                }
                else
                {
                    unit.Hp -= Damage;
                }
            }

        }

        public void ReplenishAmmunition(Armory armory)
        {
            if (armory.NumberMaterial > 50)
            {
                Console.WriteLine("Пополнение стрел");
                for (int i = 0; i < Ammunition; i++)
                {
                    Ammunition += 1;
                }
            }
            else
            {
                Console.WriteLine($"Нехватка стрел в {armory.Name}");
            }
        }
    }
}
