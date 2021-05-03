using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Smirnov.Json
{
    class Student
    {
        public string Name { get; set; }
        public int Group { get; set; }
        public int Age { get; set; }
        public Student(string name, int group, int age)
        {
            Name = name;
            Group = group;
            Age = age;
        }
    }
}
