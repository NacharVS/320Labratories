using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Lumberjack : Worker, ICutDownTree, IGetMaterial // lesorub
    {
        public override int Force { get; set; }
        public override int TypeOfWeapon { get; set; }

        public int CutDownTree()
        {
            throw new NotImplementedException();
        }

        public int GetMaterial()
        {
            throw new NotImplementedException();
        }
    }
}
