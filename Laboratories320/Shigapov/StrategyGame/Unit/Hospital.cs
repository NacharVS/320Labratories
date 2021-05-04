using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.StrategyGame
{
    class Hospital : BuildingUnit,IHeal
    {
        public override int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Heal(Unit u)
        {
            throw new NotImplementedException();
        }

    }
}
