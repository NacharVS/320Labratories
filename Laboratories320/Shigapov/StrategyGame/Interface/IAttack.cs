using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.StrategyGame
{
    interface IAttack
    {
        public int Damage { get; }
        void Attack();
    }
}
