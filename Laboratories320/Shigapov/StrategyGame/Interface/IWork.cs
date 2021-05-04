using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.StrategyGame.Interface
{
    interface IWork
    {
        public double Efficiency { get; set; }
        void Work();
    }
}
