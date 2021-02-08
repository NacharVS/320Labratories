using Laboratories320.Volkov._1_practice.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Volkov._1_practice.War_Units
{
    public class Archer : Unit, IAttackable, IMoveable, IDefendable, IDestroy
    {
        public int Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Defend(Unit unit)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
        public Archer(string name, int health) : base(name, health)
        {

        }
    }
}
