using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Peasant : Worker, IAnimalCare // krestyanin
    {
        public override int Force { get; set; }
        public override int TypeOfWeapon { get; set; }

        public int AnimalCare()
        {
            throw new NotImplementedException();
        }
    }
}
