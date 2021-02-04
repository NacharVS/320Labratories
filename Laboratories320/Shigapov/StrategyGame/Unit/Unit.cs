using Laboratories320.Shigapov.StrategyGame.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.StrategyGame
{
    abstract class Unit: IKill
    {
        public abstract int Health { get; set; }

        public void Kill()
        {
            Health = 0;
        }

    }
}
