using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Praktika
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Group { get; set; }
        
        public Student(string name, int age, int group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
    }
}
