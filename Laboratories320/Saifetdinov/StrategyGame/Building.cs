using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Building : IWaitingBuilder, IBuildingDestroyed
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Race { get; set; }
        public int AreaCastle { get; set; }

        public void BuildinDestroyed()
        {
            Console.WriteLine("The building was broken down");
        }

        public void WaitingBuilder()
        {
            Console.WriteLine("Builder's expectation");
        }
    }
}
