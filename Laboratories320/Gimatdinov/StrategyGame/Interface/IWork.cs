using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gimatdinov.StrategyGame.Interface
{
    interface IWork
    {
        public double Efficiency { get; set; }
        void Work();
    }
}
