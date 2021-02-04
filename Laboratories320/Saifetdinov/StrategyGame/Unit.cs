using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Unit :  IMovementOfThePointer, IAttack
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Race { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }

        public Unit(string name, int level, int health, int race, int damage, int speed)
        {
            this.Name = name;
            this.Level = level;
            this.Health = health;
            this.Race = race;
            this.Damage = damage;
            this.Speed = speed;
        }

        public void Attack()
        {
            Console.WriteLine("For the Motherland!!!");
        }

        public void MovementOfThePointer()
        {
            Console.WriteLine("Yes I`m coming I`m coming");
        }
    }
}
