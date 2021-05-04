using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.StrategyGame.Interface
{
    interface IMove
    {
        public int X { get; set; }
        public int Y { get; set; }
        void Move();
    }
}
