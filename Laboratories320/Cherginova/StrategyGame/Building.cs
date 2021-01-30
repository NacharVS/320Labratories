using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    abstract class Building
    {
        abstract public int Strength { get; set; } //prochnost'
        abstract public int NumberOfPeople { get; set; }
    }
}
