using Laboratories320.Gimatdinov.StrategyGame.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gimatdinov.StrategyGame
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
