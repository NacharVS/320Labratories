namespace JsonSerialize
{
    class Student
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public int Group { get; set; }
        public Student()
        {

        }
        public Student(string fullName, int age, int group)
        {
            FullName = fullName;
            Age = age;
            Group = group;
        }
    }
}
