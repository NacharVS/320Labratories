using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    abstract class Military //военный, тип, базовый 
    {
        abstract public int Health { get; set; }
        abstract public int Armor { get; set; } // bronya
        abstract public int Force { get; set; } // sila
    }
}
