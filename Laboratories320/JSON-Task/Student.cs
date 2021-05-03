using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Student
    {
        private static int idCounter = 0;
        public int Id { get; private set; } = ++idCounter;
        public string Name { get; set; }
        public int Group { get; set; }

        public override string ToString()
        {
            return $"-------------------------------\n\tId: {Id}\n\tName: {Name}\n\tGroup: {Group}\n-------------------------------\n";
        }
    }
}
