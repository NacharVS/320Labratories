using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.task_14._01._21
{
    class Fairy : IHealth, IMove, IHeal
    {
        public string name;
        public double power;
        public string spesialPower;
        public double kindness;

        public int Helth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Heal()
        {
            throw new NotImplementedException();
        }

        public void Health()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
