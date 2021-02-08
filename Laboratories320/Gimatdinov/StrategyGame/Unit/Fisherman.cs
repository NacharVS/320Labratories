using Laboratories320.Gimatdinov.StrategyGame.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gimatdinov.StrategyGame
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
