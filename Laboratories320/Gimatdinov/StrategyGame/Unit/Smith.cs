using Laboratories320.Gimatdinov.StrategyGame.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gimatdinov.StrategyGame
{
    class Smith : WorkerUnit, IMake// Кузнец
    {
        public override int Health { get; set; } = 50;

        public void IMake()
        {
            throw new NotImplementedException();
        }
    }
}
