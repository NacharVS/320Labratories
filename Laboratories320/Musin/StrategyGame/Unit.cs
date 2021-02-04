using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Musin.StrategyGame
{
    abstract class Unit : IDestroyable
    {
        public abstract string Name { get; set; }
        
        public abstract int Health { get; set; }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
    } 
}
