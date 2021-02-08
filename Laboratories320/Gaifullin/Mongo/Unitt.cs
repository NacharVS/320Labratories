using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gaifullin.Mongo
{
    abstract class Unitt : IKill
    {
        public abstract int Health { get; set; }
        public virtual int Health { get; set; }

        public void Kill()
        {
        }

    }
}