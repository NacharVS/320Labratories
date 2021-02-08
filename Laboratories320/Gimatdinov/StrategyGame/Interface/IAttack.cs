using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gimatdinov.StrategyGame
{
    interface IAttack
    {
        public int Damage { get; }
        void Attack();
    }
}
