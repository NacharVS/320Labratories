using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.StrategyGame
{
    class BuildingUnit : Unit, IRecover
    {
        public override int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Recover()
        {
            throw new NotImplementedException();
        }
    }
}
