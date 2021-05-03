using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    class Student
    {
        public string Name;
        public int Group;
        public int Age;

        public Student(string name, int group, int age)
        {
            Name = name;
            Group = group;
            Age = age;
        }
    }
}
