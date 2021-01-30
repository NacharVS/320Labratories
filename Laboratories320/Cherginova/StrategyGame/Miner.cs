using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Miner : Worker, IGetMaterial// shahter
    {
        public override int Force { get; set; }
        public override int TypeOfWeapon { get; set; }

        public int GetMaterial()
        {
            throw new NotImplementedException();
        }
    }
}
