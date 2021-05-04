using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.StrategyGame
{
    class Doctor : WorkerUnit , IHeal
    {
        public override int Health { get; set; } = 100;

        public void Heal(Unit u)
        {
            throw new NotImplementedException();
        }
    }
}
