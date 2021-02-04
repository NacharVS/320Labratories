using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Worker :  IMovementOfThePointer
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Race { get; set; }
        public int OpeningHours { get; set; }

        public void MovementOfThePointer()
        {
            Console.WriteLine("will give boots?");
        }
    }
}
