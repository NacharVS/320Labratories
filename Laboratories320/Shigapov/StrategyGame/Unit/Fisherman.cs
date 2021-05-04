using Laboratories320.Shigapov.StrategyGame.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.StrategyGame
{
    class Fisherman : WorkerUnit, IToFish// Рыбак
    {
        public override int Health { get; set; } = 120;

        public void ToFish()
        {
            throw new NotImplementedException();
        }
    }
}
