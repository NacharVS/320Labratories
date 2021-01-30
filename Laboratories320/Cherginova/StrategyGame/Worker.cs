using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    abstract class Worker //базовый
    {
        abstract public int Force { get; set; }
        abstract public int TypeOfWeapon { get; set; }
    }
}
